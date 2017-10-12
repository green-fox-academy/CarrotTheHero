using NUnit.Framework;
using UniqueChars;

namespace UniqueCharsTest
{
    [TestFixture]
    public class UniqueTest
    {
        [Test]
        public void UniqueCharactersTest()
        {
            string inputWord = "catt";
            char[] output = { 'c', 'a', 't' };
            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }

        [Test]
        public void UniqueCharactersTestWithSpaces()
        {
            string inputWord = "c a t t";
            char[] output = { 'c', 'a', 't' };
            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }

        [Test]
        public void UniqueCharactersTestWithUppercase()
        {
            string inputWord = "CaTt";
            char[] output = { 'c', 'a', 't' };
            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }
    }
}
