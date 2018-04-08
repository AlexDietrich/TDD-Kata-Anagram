using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Anagram
{
    [TestFixture]
    internal class AnagramTests
    {
        [Test]
        public void Hello_World()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void NoCharacters()
        {
            var expected = new List<string> {""};
            var result = Program.BuildAnagram("");
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void OneCharacter()
        {
            var expected = new List<string> {"A"};
            var result = Program.BuildAnagram("A");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TwoCharacter()
        {
            var expected = new List<string> {"AB", "BA"};
            var result = Program.BuildAnagram("AB");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ThreeCharacter()
        {
            var expected = new List<string> { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
            var result = Program.BuildAnagram("ABC");
            Assert.AreEqual(expected, result);
        }
    }
}
