using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Math;
using System.Collections.Generic;

namespace EcoPulse.Gates
{
    /// <summary>
    /// Static definitions for double door occupancy patterns.
    /// </summary>
    public static class GateOccupancy
    {
        /// <summary>
        /// Standard 2x2 double door occupancy pattern.
        /// z=0: Building occupancy (4 blocks)
        /// z=1: Construction blocking only (4 blocks)
        /// z=-1: Construction blocking only (4 blocks)
        /// </summary>
        public static List<BlockOccupancy> DoubleDoor => new List<BlockOccupancy>
        {
            // z=0: Building occupancy
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(0, 1, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 1, 0), typeof(BuildingWorldObjectBlock)),

            // z=1: Construction blocking only
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),

            // z=-1: Construction blocking only
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 1, -1)),
        };

        /// <summary>
        /// Standard 1x2 single garden door occupancy pattern.
        /// z=0: Building occupancy (2 blocks)
        /// z=1: Construction blocking only (2 blocks)
        /// z=-1: Construction blocking only (2 blocks)
        /// </summary>
        public static List<BlockOccupancy> StraightGardenDoor => new List<BlockOccupancy>
        {
            // z=0: Building occupancy
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(0, 1, 0), typeof(BuildingWorldObjectBlock)),

            // z=1: Construction blocking only
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),

            // z=-1: Construction blocking only
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
        };

        /// <summary>
        /// Standard 1x2 single gothic garden door occupancy pattern (same as StraightGardenDoor).
        /// </summary>
        public static List<BlockOccupancy> GothicGardenDoor => StraightGardenDoor;

        /// <summary>
        /// Standard 5x4 grill occupancy pattern.
        /// z=0: Building occupancy (20 blocks)
        /// z=1,2: Construction blocking only (20 blocks)
        /// z=-1,-2: Construction blocking only (20 blocks)
        /// </summary>
        public static List<BlockOccupancy> Grill => new List<BlockOccupancy>
        {
            // z=0: Building occupancy
            new BlockOccupancy(new Vector3i(0, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(0, 1, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(0, 2, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(0, 3, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 1, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 2, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 3, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(2, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(2, 1, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(2, 2, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(2, 3, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(3, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(3, 1, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(3, 2, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(3, 3, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(4, 0, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(4, 1, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(4, 2, 0), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(4, 3, 0), typeof(BuildingWorldObjectBlock)),

            // z=1 and z=2: Construction blocking only
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 1, 1)),
            new BlockOccupancy(new Vector3i(0, 1, 2)),
            new BlockOccupancy(new Vector3i(0, 2, 1)),
            new BlockOccupancy(new Vector3i(0, 2, 2)),
            new BlockOccupancy(new Vector3i(0, 3, 1)),
            new BlockOccupancy(new Vector3i(0, 3, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 1, 1)),
            new BlockOccupancy(new Vector3i(1, 1, 2)),
            new BlockOccupancy(new Vector3i(1, 2, 1)),
            new BlockOccupancy(new Vector3i(1, 2, 2)),
            new BlockOccupancy(new Vector3i(1, 3, 1)),
            new BlockOccupancy(new Vector3i(1, 3, 2)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 1, 1)),
            new BlockOccupancy(new Vector3i(2, 1, 2)),
            new BlockOccupancy(new Vector3i(2, 2, 1)),
            new BlockOccupancy(new Vector3i(2, 2, 2)),
            new BlockOccupancy(new Vector3i(2, 3, 1)),
            new BlockOccupancy(new Vector3i(2, 3, 2)),
            new BlockOccupancy(new Vector3i(3, 0, 1)),
            new BlockOccupancy(new Vector3i(3, 0, 2)),
            new BlockOccupancy(new Vector3i(3, 1, 1)),
            new BlockOccupancy(new Vector3i(3, 1, 2)),
            new BlockOccupancy(new Vector3i(3, 2, 1)),
            new BlockOccupancy(new Vector3i(3, 2, 2)),
            new BlockOccupancy(new Vector3i(3, 3, 1)),
            new BlockOccupancy(new Vector3i(3, 3, 2)),
            new BlockOccupancy(new Vector3i(4, 0, 1)),
            new BlockOccupancy(new Vector3i(4, 0, 2)),
            new BlockOccupancy(new Vector3i(4, 1, 1)),
            new BlockOccupancy(new Vector3i(4, 1, 2)),
            new BlockOccupancy(new Vector3i(4, 2, 1)),
            new BlockOccupancy(new Vector3i(4, 2, 2)),
            new BlockOccupancy(new Vector3i(4, 3, 1)),
            new BlockOccupancy(new Vector3i(4, 3, 2)),

            // z=-1 and z=-2: Construction blocking only
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, -2)),
            new BlockOccupancy(new Vector3i(0, 1, -1)),
            new BlockOccupancy(new Vector3i(0, 1, -2)),
            new BlockOccupancy(new Vector3i(0, 2, -1)),
            new BlockOccupancy(new Vector3i(0, 2, -2)),
            new BlockOccupancy(new Vector3i(0, 3, -1)),
            new BlockOccupancy(new Vector3i(0, 3, -2)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 0, -2)),
            new BlockOccupancy(new Vector3i(1, 1, -1)),
            new BlockOccupancy(new Vector3i(1, 1, -2)),
            new BlockOccupancy(new Vector3i(1, 2, -1)),
            new BlockOccupancy(new Vector3i(1, 2, -2)),
            new BlockOccupancy(new Vector3i(1, 3, -1)),
            new BlockOccupancy(new Vector3i(1, 3, -2)),
            new BlockOccupancy(new Vector3i(2, 0, -1)),
            new BlockOccupancy(new Vector3i(2, 0, -2)),
            new BlockOccupancy(new Vector3i(2, 1, -1)),
            new BlockOccupancy(new Vector3i(2, 1, -2)),
            new BlockOccupancy(new Vector3i(2, 2, -1)),
            new BlockOccupancy(new Vector3i(2, 2, -2)),
            new BlockOccupancy(new Vector3i(2, 3, -1)),
            new BlockOccupancy(new Vector3i(2, 3, -2)),
            new BlockOccupancy(new Vector3i(3, 0, -1)),
            new BlockOccupancy(new Vector3i(3, 0, -2)),
            new BlockOccupancy(new Vector3i(3, 1, -1)),
            new BlockOccupancy(new Vector3i(3, 1, -2)),
            new BlockOccupancy(new Vector3i(3, 2, -1)),
            new BlockOccupancy(new Vector3i(3, 2, -2)),
            new BlockOccupancy(new Vector3i(3, 3, -1)),
            new BlockOccupancy(new Vector3i(3, 3, -2)),
            new BlockOccupancy(new Vector3i(4, 0, -1)),
            new BlockOccupancy(new Vector3i(4, 0, -2)),
            new BlockOccupancy(new Vector3i(4, 1, -1)),
            new BlockOccupancy(new Vector3i(4, 1, -2)),
            new BlockOccupancy(new Vector3i(4, 2, -1)),
            new BlockOccupancy(new Vector3i(4, 2, -2)),
            new BlockOccupancy(new Vector3i(4, 3, -1)),
            new BlockOccupancy(new Vector3i(4, 3, -2)),
        };

        /// <summary>
        /// Castle draw bridge occupancy pattern.
        /// Aligned with client Override Occupancy: offset=(-2,0,-6), size=(6,6,7).
        /// Volume: x in [-2..3], y in [0..5], z in [-6..0].
        /// Wall/pillars at z=-6, plank extends z=-5..0.
        /// </summary>
        public static List<BlockOccupancy> CastleDrawBridge => new List<BlockOccupancy>
        {
            // Wall base row (x=-2..3, y=0, z=-6) - building occupancy
            new BlockOccupancy(new Vector3i(-2, 0, -6), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(-1, 0, -6), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(0, 0, -6), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 0, -6), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(2, 0, -6), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(3, 0, -6), typeof(BuildingWorldObjectBlock)),

            // Left pillar height (x=-2, y=1..5, z=-6)
            new BlockOccupancy(new Vector3i(-2, 1, -6)),
            new BlockOccupancy(new Vector3i(-2, 2, -6)),
            new BlockOccupancy(new Vector3i(-2, 3, -6)),
            new BlockOccupancy(new Vector3i(-2, 4, -6)),
            new BlockOccupancy(new Vector3i(-2, 5, -6)),

            // Right pillar height (x=3, y=1..5, z=-6)
            new BlockOccupancy(new Vector3i(3, 1, -6)),
            new BlockOccupancy(new Vector3i(3, 2, -6)),
            new BlockOccupancy(new Vector3i(3, 3, -6)),
            new BlockOccupancy(new Vector3i(3, 4, -6)),
            new BlockOccupancy(new Vector3i(3, 5, -6)),

            // Arch/wall top (x=-1..2, y=4..5, z=-6)
            new BlockOccupancy(new Vector3i(-1, 4, -6)),
            new BlockOccupancy(new Vector3i(-1, 5, -6)),
            new BlockOccupancy(new Vector3i(0, 4, -6)),
            new BlockOccupancy(new Vector3i(0, 5, -6)),
            new BlockOccupancy(new Vector3i(1, 4, -6)),
            new BlockOccupancy(new Vector3i(1, 5, -6)),
            new BlockOccupancy(new Vector3i(2, 4, -6)),
            new BlockOccupancy(new Vector3i(2, 5, -6)),

            // Plank area when down (x=-2..3, y=0, z=-5..0)
            new BlockOccupancy(new Vector3i(-2, 0, -5)),
            new BlockOccupancy(new Vector3i(-1, 0, -5)),
            new BlockOccupancy(new Vector3i(0, 0, -5)),
            new BlockOccupancy(new Vector3i(1, 0, -5)),
            new BlockOccupancy(new Vector3i(2, 0, -5)),
            new BlockOccupancy(new Vector3i(3, 0, -5)),
            new BlockOccupancy(new Vector3i(-2, 0, -4)),
            new BlockOccupancy(new Vector3i(-1, 0, -4)),
            new BlockOccupancy(new Vector3i(0, 0, -4)),
            new BlockOccupancy(new Vector3i(1, 0, -4)),
            new BlockOccupancy(new Vector3i(2, 0, -4)),
            new BlockOccupancy(new Vector3i(3, 0, -4)),
            new BlockOccupancy(new Vector3i(-2, 0, -3)),
            new BlockOccupancy(new Vector3i(-1, 0, -3)),
            new BlockOccupancy(new Vector3i(0, 0, -3)),
            new BlockOccupancy(new Vector3i(1, 0, -3)),
            new BlockOccupancy(new Vector3i(2, 0, -3)),
            new BlockOccupancy(new Vector3i(3, 0, -3)),
            new BlockOccupancy(new Vector3i(-2, 0, -2)),
            new BlockOccupancy(new Vector3i(-1, 0, -2)),
            new BlockOccupancy(new Vector3i(0, 0, -2)),
            new BlockOccupancy(new Vector3i(1, 0, -2)),
            new BlockOccupancy(new Vector3i(2, 0, -2)),
            new BlockOccupancy(new Vector3i(3, 0, -2)),
            new BlockOccupancy(new Vector3i(-2, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(2, 0, -1)),
            new BlockOccupancy(new Vector3i(3, 0, -1)),
            new BlockOccupancy(new Vector3i(-2, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(3, 0, 0)),
        };

        /// <summary>
        /// Wooden draw bridge occupancy pattern.
        /// Aligned with client Override Occupancy: offset=(-2,0,-4), size=(5,5,10).
        /// Volume: x in [-2..2], y in [0..4], z in [-4..5].
        /// Pillars at the two sides (x=-2, x=+2) at z=-4, tablier extending forward (z=-3..5).
        /// </summary>
        public static List<BlockOccupancy> DrawBridge => new List<BlockOccupancy>
        {
            // Pillars base row (x=-2..2, y=0, z=-4) - building occupancy
            new BlockOccupancy(new Vector3i(-2, 0, -4), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(-1, 0, -4), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(0, 0, -4), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(1, 0, -4), typeof(BuildingWorldObjectBlock)),
            new BlockOccupancy(new Vector3i(2, 0, -4), typeof(BuildingWorldObjectBlock)),

            // Left pillar height (x=-2, y=1..4, z=-4) - construction blocking
            new BlockOccupancy(new Vector3i(-2, 1, -4)),
            new BlockOccupancy(new Vector3i(-2, 2, -4)),
            new BlockOccupancy(new Vector3i(-2, 3, -4)),
            new BlockOccupancy(new Vector3i(-2, 4, -4)),

            // Right pillar height (x=2, y=1..4, z=-4) - construction blocking
            new BlockOccupancy(new Vector3i(2, 1, -4)),
            new BlockOccupancy(new Vector3i(2, 2, -4)),
            new BlockOccupancy(new Vector3i(2, 3, -4)),
            new BlockOccupancy(new Vector3i(2, 4, -4)),

            // Plank area when down (x=-2..2, y=0, z=-3..5) - construction blocking
            new BlockOccupancy(new Vector3i(-2, 0, -3)),
            new BlockOccupancy(new Vector3i(-1, 0, -3)),
            new BlockOccupancy(new Vector3i(0, 0, -3)),
            new BlockOccupancy(new Vector3i(1, 0, -3)),
            new BlockOccupancy(new Vector3i(2, 0, -3)),
            new BlockOccupancy(new Vector3i(-2, 0, -2)),
            new BlockOccupancy(new Vector3i(-1, 0, -2)),
            new BlockOccupancy(new Vector3i(0, 0, -2)),
            new BlockOccupancy(new Vector3i(1, 0, -2)),
            new BlockOccupancy(new Vector3i(2, 0, -2)),
            new BlockOccupancy(new Vector3i(-2, 0, -1)),
            new BlockOccupancy(new Vector3i(-1, 0, -1)),
            new BlockOccupancy(new Vector3i(0, 0, -1)),
            new BlockOccupancy(new Vector3i(1, 0, -1)),
            new BlockOccupancy(new Vector3i(2, 0, -1)),
            new BlockOccupancy(new Vector3i(-2, 0, 0)),
            new BlockOccupancy(new Vector3i(-1, 0, 0)),
            new BlockOccupancy(new Vector3i(0, 0, 0)),
            new BlockOccupancy(new Vector3i(1, 0, 0)),
            new BlockOccupancy(new Vector3i(2, 0, 0)),
            new BlockOccupancy(new Vector3i(-2, 0, 1)),
            new BlockOccupancy(new Vector3i(-1, 0, 1)),
            new BlockOccupancy(new Vector3i(0, 0, 1)),
            new BlockOccupancy(new Vector3i(1, 0, 1)),
            new BlockOccupancy(new Vector3i(2, 0, 1)),
            new BlockOccupancy(new Vector3i(-2, 0, 2)),
            new BlockOccupancy(new Vector3i(-1, 0, 2)),
            new BlockOccupancy(new Vector3i(0, 0, 2)),
            new BlockOccupancy(new Vector3i(1, 0, 2)),
            new BlockOccupancy(new Vector3i(2, 0, 2)),
            new BlockOccupancy(new Vector3i(-2, 0, 3)),
            new BlockOccupancy(new Vector3i(-1, 0, 3)),
            new BlockOccupancy(new Vector3i(0, 0, 3)),
            new BlockOccupancy(new Vector3i(1, 0, 3)),
            new BlockOccupancy(new Vector3i(2, 0, 3)),
            new BlockOccupancy(new Vector3i(-2, 0, 4)),
            new BlockOccupancy(new Vector3i(-1, 0, 4)),
            new BlockOccupancy(new Vector3i(0, 0, 4)),
            new BlockOccupancy(new Vector3i(1, 0, 4)),
            new BlockOccupancy(new Vector3i(2, 0, 4)),
            new BlockOccupancy(new Vector3i(-2, 0, 5)),
            new BlockOccupancy(new Vector3i(-1, 0, 5)),
            new BlockOccupancy(new Vector3i(0, 0, 5)),
            new BlockOccupancy(new Vector3i(1, 0, 5)),
            new BlockOccupancy(new Vector3i(2, 0, 5)),
        };
    }
}
