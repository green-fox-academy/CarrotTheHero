using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;

namespace SumTest
{
    [TestFixture]
    public class SummingTest
    {
        Summing sumtard = new Summing();

        [Test]
        public void PrintSumTest()
        {
            List<int> sumList = new List<int>{ 1, 2, 5, 6, 10, 17 };
            int output = 41;

            Assert.AreEqual(output, sumtard.Sum(sumList));
        }

        [Test]
        public void PrintSumTest2()
        {
            List<int> sumList = new List<int> { };
            int output = 0;

            Assert.AreEqual(output, sumtard.Sum(sumList));
        }

        [Test]
        public void PrintSumTest3()
        {
            List<int> sumList = new List<int> {12};
            int output = 12;

            Assert.AreEqual(output, sumtard.Sum(sumList));
        }

        [Test]
        public void PrintSumTest4()
        {
            List<int> sumList = new List<int>();
            int output = 0;

            Assert.AreEqual(output, sumtard.Sum(null));
        }
    }
}
