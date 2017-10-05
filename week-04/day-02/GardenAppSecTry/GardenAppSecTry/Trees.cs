using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenAppSecTry
{
    class Trees : Plants
    {
        public Trees(string name) : base(name)
        {
            MinWaterLevel = 5;
            Absorb = 0.75f;
            PlantType = "tree";
        }
    }
}
