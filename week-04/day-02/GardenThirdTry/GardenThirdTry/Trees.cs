using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenThirdTry
{
    class Trees : Plants
    {
        public Trees(string name) : base(name)
        {
            MinWaterLvL = 10;
            Absorb = 0.4f;
            PlantType = "tree";
        }
    }
}
