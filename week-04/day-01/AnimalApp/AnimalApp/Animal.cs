using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Animal
    {
        protected int hunger = 50;
        protected int thirst = 50;

        protected void Eat()
        {
            hunger--;
        }
        protected void Drink()
        {
            thirst--;
        }
        protected void Play()
        {
            hunger++;
            thirst++;
        }
    }
}
