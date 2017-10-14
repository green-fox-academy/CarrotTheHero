using NUnit.Framework;
using UniChar;

namespace UniCharTest
{
    [TestFixture]
    public class UniCharsTest
    {
        [Test]
        public void TestingTheBasicInput()
        {
            string inputWord = "doggy";
            char[] output = { 'd', 'o', 'g', 'y' };
            Assert.AreEqual(output, UniChars.Chars(inputWord));
        }

        [Test]
        public void TestingInputWithSpaces()
        {
            string inputWord = "d o g g y";
            char[] output = { 'd', 'o', 'g', 'y' };
            Assert.AreEqual(output, UniChars.Chars(inputWord));
        }

        [Test]
        public void TestingInputWithUppercase()
        {
            string inputWord = "dOgGy";
            char[] output = { 'd', 'o', 'g', 'y' };
            Assert.AreEqual(output, UniChars.Chars(inputWord));
        }
    }
}
