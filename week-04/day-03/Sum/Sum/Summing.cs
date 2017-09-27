using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Summing
    {
        public int Sum(List<int> SumList)
        {
            int sum = 0;

            foreach (int number in SumList)
            {
                sum += number;
            }

            return sum;
        }
    }
}
