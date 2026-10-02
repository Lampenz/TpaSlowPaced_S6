using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPulse.StatueMod
{
    public class SquirrelStatue
    {
        public static List<BlockOccupancy> GetOccupency()
        {
            return new List<BlockOccupancy>()
            {
                new BlockOccupancy(new Vector3i(0, 0, 0)),

                new BlockOccupancy(new Vector3i(0, 1, 0))
            };
        }
    }
}

