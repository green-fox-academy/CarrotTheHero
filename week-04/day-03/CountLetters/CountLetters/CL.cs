using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class CL
    {
        public Dictionary<char, int> MyFunction(string input)
        {

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!dictionary.ContainsKey(letter))
                {
                    dictionary.Add(letter, 1);
                }
                else
                {

                    dictionary[letter]++;
                }
            }
            return dictionary;
        }
    }
}
