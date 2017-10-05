using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Plants
    {
        string Name;
        protected string PlantType;
        protected float MinWaterLevel;
        protected float Absorbs;
        float ActualWaterLevel;
               
        public Plants(string name)
        {
            Name = name;
        }

        public bool WaterIsNeaded()
        {
            return ActualWaterLevel < MinWaterLevel;
        }

        public void Water(float waterAmount)
        {
            ActualWaterLevel += waterAmount * Absorbs;
        }

        public void GetStatus()
        {
            string status = "doesn't need water";
            if (WaterIsNeaded())
            {
                status = "needs water";
            }
            Console.WriteLine("The {0} {1} {2}",Name, PlantType, status);
        }
    }
}
