using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenThirdTry
{
    class Flowers : Plants
    {
        public Flowers(string name) : base(name)
        {
            MinWaterLvL = 5;
            Absorb = 0.75f;
            PlantType = "flower";
        }
    }
}
