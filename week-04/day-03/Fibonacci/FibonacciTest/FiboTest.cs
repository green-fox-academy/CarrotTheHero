using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci;
using NUnit.Framework;

namespace FibonacciTest
{
    [TestFixture]
    public class FiboTest
    {
        [Test]
        public void FiboSolve()
        {
            Fibo fibona = new Fibo();
            int output = 21;


            Assert.AreEqual(output, fibona.GetNthFibonacciWithFor(8));
        }
    }
}
