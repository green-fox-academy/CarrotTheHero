using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenThirdTry
{
    class Plants
    {
        string Name;
        protected float MinWaterLvL;
        protected float Absorb;
        protected string PlantType;
        float CurrentWaterLvL;


        public Plants(string name)
        {
            Name = name;
        }

        public bool WaterIsNeeded()
        {
            return MinWaterLvL > CurrentWaterLvL;
        }

        public void Water(float howmuchWater)
        {
            CurrentWaterLvL += howmuchWater * Absorb;
        }

        internal void GetStatus()
        {
            string status = "doesn't need water";
            if (WaterIsNeeded())
            {
                status = "needs more water";
            }
            Console.WriteLine("The {0} {1} {2}", Name, PlantType, status);
        }
    }
}
