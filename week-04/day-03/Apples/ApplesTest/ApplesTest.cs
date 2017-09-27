using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ApplesApp;

namespace ApplesTest
{
    [TestFixture]
    public class ApplesTest
    {
        Apples apple = new Apples();
        [Test]
        public void PrintAppleTest()
        {
            string output = "apples";

            Assert.AreEqual(output, apple.GetApples());
        }
    }
}
