using RomanConvertConsole;

namespace RomanConvertConsoleNUnitTest
{
    public class RomanConvertTest
    {
        RomanConvert romanConvert = new RomanConvert();
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        [TestCase(2014, "MMXIV")]
        [TestCase(2814, "MMDCCCXIV")]
        public void SolveTest(int value, string expected)
        {
            Assert.That(romanConvert.Solution(value), Is.EqualTo(expected));
        }
    }
}