using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class Program
    {        
        public static bool Anagramma(string word1,string word2)
        {
                        
                string word1letters = String.Concat(word1.OrderBy(c => c));
                string word2letters = String.Concat(word2.OrderBy(c => c));

            if (word1letters == word2letters)
                return true;

            else
                return false;
        }
    }
}
