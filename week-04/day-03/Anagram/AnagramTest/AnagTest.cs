using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void PrintAnagram()
        {
            Program program = new Program();

            Assert.AreEqual(true,Program.Anagramma("vajaskalacs","kavajacsals"));
        }
    }
}
