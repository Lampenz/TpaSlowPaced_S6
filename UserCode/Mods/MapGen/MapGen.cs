// MapGen — injects a hand-generated island map (.mapgen, produced by the Eco Island
// Map Generator) into Eco's world generation, so a FRESH world is built from your map.
//
// HOW IT WORKS
//   Eco builds terrain by sampling four SharpNoise modules (Height/Water/Rainfall/Temperature)
//   that delegate to VoronoiWorldGeneratorConfig.GenerateWorld() and read its cached
//   HeightData/WaterData/RainfallData/TemperatureData arrays, plus the static Biome.BiomeData.
//   This plugin runs BEFORE the world generator (Priority -4 < WorldGenerator's -3), builds those
//   arrays from the .mapgen file, drops a pre-filled generator into the config's cache, and sets
//   Biome.BiomeData. Every module then samples OUR data — no engine patching, no SharpNoise ref.
//
//   We never call vanilla Generate(), so the Voronoi map is never computed. Note: Eco's
//   HeightmapModule/WaterModule wrap our values in an EcoTerraceNode (terracing) — that only
//   quantizes heights into Eco's usual stepped look and preserves the coastline, which is fine.
//
// INSTALL
//   1. Put this folder under  <Server>/Mods/UserCode/MapGen/
//   2. Generate a map at the world's resolution and export it:
//        node EcoMapGenerator/render.cjs <seed> 720 out.png --export Map.mapgen
//      (720 = VoxelSize for the Small preset = chunks(72) * 10. Match your preset's VoxelSize.)
//   3. Copy Map.mapgen into  <Server>/Configs/Map.mapgen
//   4. Start a FRESH world (delete/move the existing Storage world first). On an existing world
//      this plugin no-ops. Watch the console for "[MapGen]" lines.

namespace Eco.Mods.MapGen
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using Eco.Core.Plugins.Interfaces;
    using Eco.Core.Utils;                  // PriorityAttribute, TimedTask
    using Eco.Shared.Localization;
    using Eco.Shared.Logging;
    using Eco.Shared.Math;                 // Vector2i
    using Eco.Shared.Utils;                // Array2D
    using Eco.WorldGenerator;              // Biome, WorldGeneratorPlugin, WorldSettings, VoronoiWorldGenerator(Config)
    using World = Eco.World.World;         // alias to avoid any Eco.World namespace/type ambiguity

    [Priority(-4)] // must be < PluginPriorities.WorldGenerator (-3) so we Initialize() first
    public class MapGenPlugin : IModKitPlugin, IInitializablePlugin
    {
        // Candidate locations for the map file (first existing wins).
        static readonly string[] CandidatePaths =
        {
            Path.Combine("Configs", "Map.mapgen"),
            Path.Combine("Mods", "UserCode", "MapGen", "Map.mapgen"),
            "Map.mapgen",
        };

        string status = "Idle";
        public string GetStatus()   => this.status;
        public string GetCategory() => "World Generation";

        public void Initialize(TimedTask timer)
        {
            try { this.TryInject(); }
            catch (Exception e)
            {
                this.status = "Failed";
                Log.WriteErrorLineLoc($"[MapGen] Injection failed, falling back to vanilla generation: {e}");
            }
        }

        void TryInject()
        {
            // Only meaningful on a brand-new world (generation only runs when empty).
            if (World.ChunksCount != 0)
            {
                this.status = "Skipped (world already exists)";
                Log.WriteLine(Localizer.DoStr("[MapGen] World already generated — skipping map injection."));
                return;
            }

            var path = FindMapFile();
            if (path == null)
            {
                this.status = "No map file";
                Log.WriteLine(Localizer.DoStr("[MapGen] No Map.mapgen found (checked Configs/). Using vanilla world generation."));
                return;
            }

            var vox = WorldGeneratorPlugin.Settings.VoxelSize;
            var map = MapGenFile.Load(path);
            if (map.Width != vox.x || map.Height != vox.y)
            {
                this.status = "Size mismatch";
                Log.WriteErrorLineLoc($"[MapGen] Map is {map.Width}x{map.Height} but world VoxelSize is {vox.x}x{vox.y}. Regenerate at size {vox.x} (chunks*10). Using vanilla generation.");
                return;
            }

            var size = new Vector2i(map.Width, map.Height);

            // 1. data planes -> Array2D<float> (our layout x + y*width matches Array2D.Index x + y*Size.x)
            var height = new Array2D<float>(size) { Array = map.Height01Plane }; // [-1,1]
            var water  = new Array2D<float>(size) { Array = map.WaterPlane };     // [0,1]
            var rain   = new Array2D<float>(size) { Array = map.RainfallPlane };  // [0,1]
            var temp   = new Array2D<float>(size) { Array = map.TemperaturePlane };// [0,1]

            // 2. biome grid -> Array2D<Biome>
            var biomeArr = new Biome[map.Width * map.Height];
            for (int i = 0; i < biomeArr.Length; i++)
                biomeArr[i] = NameToBiome(map.BiomeNames[map.BiomeIndex[i]]);
            var biomeData = new Array2D<Biome>(size) { Array = biomeArr };

            // 3. construct a generator, stuff our arrays into its (private-setter) properties
            var gen = new VoronoiWorldGenerator(previewOnly: false, skipSetSpawnLocation: false);
            SetProp(gen, "HeightData", height);
            SetProp(gen, "WaterData", water);
            SetProp(gen, "RainfallData", rain);
            SetProp(gen, "TemperatureData", temp);

            // 4. drop it into the config's cache so GenerateWorld() returns ours (skips vanilla Generate)
            var cfg = WorldGeneratorPlugin.Settings.VoronoiWorldGeneratorConfig;
            var genField = typeof(VoronoiWorldGeneratorConfig).GetField("generator", BindingFlags.NonPublic | BindingFlags.Instance);
            if (genField == null) throw new Exception("VoronoiWorldGeneratorConfig.generator field not found (Eco version mismatch).");
            genField.SetValue(cfg, gen);

            // 5. biome lookup used by underground/ore stamping + cliff extrusion
            Biome.BiomeData = biomeData;

            // 6. spawn: vanilla sets this inside Generate() (which we skip), so set it ourselves
            //    once generation finishes (the delegate is wired by UserManager before then).
            var (spawnX, spawnZ) = ComputeSpawn(map);
            WorldGeneratorPlugin.OnFinishGenerate.Add(() =>
            {
                var setter = WorldGeneratorPlugin.SetSpawnLocation;
                if (setter != null) setter(new Vector3i(spawnX, 0, spawnZ));
            });

            this.status = $"Injected {map.Width}x{map.Height}";
            Log.WriteLine(Localizer.Do($"[MapGen] Injected custom map {map.Width}x{map.Height} from {path}. World will be built from it."));
        }

        static string FindMapFile()
        {
            var baseDir = Directory.GetCurrentDirectory();
            foreach (var rel in CandidatePaths)
            {
                var full = Path.Combine(baseDir, rel);
                if (File.Exists(full)) return full;
                if (File.Exists(rel)) return rel;
            }
            return null;
        }

        static void SetProp(object target, string name, object value)
        {
            var p = target.GetType().GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
            if (p == null) throw new Exception($"VoronoiWorldGenerator.{name} not found (Eco version mismatch).");
            p.SetValue(target, value); // reflection invokes the private setter
        }

        // Pick a spawn (x,z): centroid-nearest Grassland cell if any, else any non-water/non-coast land.
        static (int x, int z) ComputeSpawn(MapGenFile map)
        {
            bool useGrass = Array.IndexOf(map.BiomeNames, "Grassland") >= 0;
            bool Qualifies(string name) => useGrass
                ? name == "Grassland"
                : name != "Ocean" && name != "DeepOcean" && name != "WarmCoast" && name != "ColdCoast";

            long sx = 0, sz = 0; int cnt = 0;
            for (int y = 0; y < map.Height; y++)
                for (int x = 0; x < map.Width; x++)
                    if (Qualifies(map.BiomeNames[map.BiomeIndex[x + y * map.Width]])) { sx += x; sz += y; cnt++; }

            if (cnt == 0) return (map.Width / 2, map.Height / 2);
            int cx = (int)(sx / cnt), cz = (int)(sz / cnt);

            long best = long.MaxValue; int bx = cx, bz = cz;
            for (int y = 0; y < map.Height; y++)
                for (int x = 0; x < map.Width; x++)
                {
                    if (!Qualifies(map.BiomeNames[map.BiomeIndex[x + y * map.Width]])) continue;
                    long d = (long)(x - cx) * (x - cx) + (long)(y - cz) * (y - cz);
                    if (d < best) { best = d; bx = x; bz = y; }
                }
            return (bx, bz);
        }

        static Biome NameToBiome(string n)
        {
            switch (n)
            {
                case "Grassland":  return Biome.Grassland;
                case "RainForest": return Biome.RainForest;
                case "WarmForest": return Biome.WarmForest;
                case "ColdForest": return Biome.ColdForest;
                case "Taiga":      return Biome.Taiga;
                case "Tundra":     return Biome.Tundra;
                case "Ice":        return Biome.Ice;
                case "Desert":     return Biome.Desert;
                case "Wetland":    return Biome.Wetland;
                case "Ocean":      return Biome.Ocean;
                case "DeepOcean":  return Biome.DeepOcean;
                case "ColdCoast":  return Biome.ColdCoast;
                case "WarmCoast":  return Biome.WarmCoast;
                default:           return Biome.Grassland;
            }
        }
    }

    /// <summary>Parsed .mapgen file. Layout: cell index = x + y*Width (matches Array2D.Index).</summary>
    internal sealed class MapGenFile
    {
        public int Width, Height;
        public string[] BiomeNames;
        public byte[]  BiomeIndex;       // per cell -> index into BiomeNames
        public float[] Height01Plane;    // [-1,1]
        public float[] WaterPlane;       // [0,1]
        public float[] RainfallPlane;    // [0,1]
        public float[] TemperaturePlane; // [0,1]

        public static MapGenFile Load(string path)
        {
            using var br = new BinaryReader(File.OpenRead(path), Encoding.UTF8);
            var magic = Encoding.ASCII.GetString(br.ReadBytes(8));
            if (magic != "MAPGEN01") throw new Exception($"Bad .mapgen magic '{magic}'.");
            var m = new MapGenFile();
            m.Width  = br.ReadInt32();
            m.Height = br.ReadInt32();
            int legendCount = br.ReadInt32();
            m.BiomeNames = new string[legendCount];
            for (int i = 0; i < legendCount; i++)
            {
                int len = br.ReadInt32();
                m.BiomeNames[i] = Encoding.UTF8.GetString(br.ReadBytes(len));
            }
            int nn = m.Width * m.Height;
            m.BiomeIndex = br.ReadBytes(nn);
            m.Height01Plane    = ReadFloats(br, nn);
            m.WaterPlane       = ReadFloats(br, nn);
            m.RainfallPlane    = ReadFloats(br, nn);
            m.TemperaturePlane = ReadFloats(br, nn);
            return m;
        }

        static float[] ReadFloats(BinaryReader br, int count)
        {
            var bytes = br.ReadBytes(count * 4);
            var arr = new float[count];
            Buffer.BlockCopy(bytes, 0, arr, 0, count * 4); // file is little-endian; x64 is little-endian
            return arr;
        }
    }
}
