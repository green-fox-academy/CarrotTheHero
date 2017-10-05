using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenAppSecTry
{
    class Flowers : Plants
    {
        public Flowers(string name) : base(name)
        {
            MinWaterLevel = 10;
            Absorb = 0.4f;
            PlantType = "flower";
        }
    }
}
