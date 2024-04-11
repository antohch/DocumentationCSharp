using Microsoft.VisualStudio.TestPlatform.TestHost;
using MaxSubarrySumConsole;

namespace MaxSequenceConsoleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(MaxSubarrySumConsole.Program.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }), Is.EqualTo(6));
        }
    }
}