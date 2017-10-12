using System.Linq;

namespace UniqueChars
{
    public class Unique
    {
        public static char[] UniqueCharacters(string input)
        {
            return input.Replace(" ", "").ToLower().ToCharArray().Distinct().ToArray();
        }
    }
}
