
using NUnit.Framework;
using NUnit;
using RomanConvertConsole;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;



namespace RomanConvertConsoleTest
{
    [TestFixture]
    public class RomanConvertTest
    {
        RomanConvert romanConvert;
        [SetUp]
        public void SetUp()
        {
            romanConvert = new RomanConvert();
        }
        [TestCase(1, "I")]
        public void SolutionTest(int value, string expected)
        {

            Assert.AreEqual(expected, romanConvert.Solution(value));
        }
    }
}