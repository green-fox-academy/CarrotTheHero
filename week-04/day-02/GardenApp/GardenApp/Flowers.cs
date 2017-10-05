using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Flowers : Plants
    {
        public Flowers(string name) : base(name)
        {
            MinWaterLevel = 5;
            Absorbs = 0.75f;
            PlantType = "flower";
        }
    }
}
