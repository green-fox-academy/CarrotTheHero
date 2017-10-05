using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenAppSecTry
{
    class Plants
    {
        string Name;
        protected float MinWaterLevel;
        protected float Absorb;
        float CurrentWaterLevel;
        protected string PlantType;

        public Plants(string name)
        {
            Name = name;
        }

        public bool WaterIsNeeded()
        {
            return MinWaterLevel > CurrentWaterLevel;
        }

        public void Water(float howmuchWater)
        {
            CurrentWaterLevel += howmuchWater * Absorb;
        }

        public void GetStatus()
        {
            string status = "doesn't need water";
            if (WaterIsNeeded())
            {
                status = "needs water";
            }
            Console.WriteLine("The {0} {1} {2}", Name, PlantType, status);
        }
    }
}
