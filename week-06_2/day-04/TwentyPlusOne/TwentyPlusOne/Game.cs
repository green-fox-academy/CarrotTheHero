using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        public Game()
        {
            GenerateEnemyPoints();
        }

        private void GenerateEnemyPoints()
        {
            Random random = new Random();

            int result = random.Next(15, 22);
        }
    }
}
