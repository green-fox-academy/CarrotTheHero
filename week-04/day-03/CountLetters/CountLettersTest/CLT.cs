using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CountLetters;

namespace CountLettersTest
{
    [TestFixture]
    public class CLT
    {
        [Test]

        public void Count()
        {
            CL cl = new CL();
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
            {'t', 2 },
            {'o', 3 },
            {'r', 1 },
            };

            Assert.AreEqual(output, cl.MyFunction("totoro"));
        }
    }
}
