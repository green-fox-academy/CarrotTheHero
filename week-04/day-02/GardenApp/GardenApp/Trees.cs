using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Trees : Plants
    {
        public Trees(string name) : base(name)
        {
            MinWaterLevel = 10;
            Absorbs = 0.4f;
            PlantType = "tree";
        }
    }
}
