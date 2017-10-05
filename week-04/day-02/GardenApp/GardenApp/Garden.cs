using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenApp;

namespace GardenApp
{
    class Garden
    {
        List<Plants> plants;

        public Garden()
        {

            plants = new List<Plants>();
            plants.Add(new Flowers("yellow"));
            plants.Add(new Flowers("blue"));
            plants.Add(new Trees("purple"));
            plants.Add(new Trees("orange"));
            PrintStatus();
        }

        private void PrintStatus()
        {
            foreach (Plants plant in plants)
            {
                plant.GetStatus();
            }
            Console.WriteLine();
        }

        public void Water(float totalWaterAmount)
        {
            Console.WriteLine("Watering with {0}", totalWaterAmount);
            var count = 0;

            foreach (Plants plant in plants)
            {
                if (plant.WaterIsNeaded())
                {
                    count++;
                }
            }
            if (count == 0)
            {
                PrintStatus();
                return;
            }
            var waterPerPlant = totalWaterAmount / count;
            foreach (Plants plant in plants)
            {
                if (plant.WaterIsNeaded())
                {
                    plant.Water(waterPerPlant);
                }
            }
            PrintStatus();
        }
    }
}
