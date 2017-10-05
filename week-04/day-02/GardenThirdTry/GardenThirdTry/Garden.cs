using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenThirdTry
{
    class Garden
    {
        List<Plants> plants;

        public Garden()
        {
            plants = new List<Plants>();
            plants.Add(new Flowers("yellow"));
            plants.Add(new Flowers("blue"));
            plants.Add(new Trees("puple"));
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

        public void Water(float TotalWater)
        {
            Console.WriteLine("Watering with {0}",TotalWater);
            var count = 0;

            foreach (Plants plant in plants)
            {

                if (plant.WaterIsNeeded())
                {
                    count++;
                }
            }
            if (count == 0)
            {
                PrintStatus();
                return;
            }

            var waterPerPlant = TotalWater / count;
            foreach (Plants plant in plants)
            {
                if (plant.WaterIsNeeded())
                {
                    plant.Water(waterPerPlant);
                }
            }
            PrintStatus();
        }
    }
}
