using InterpolationConsole;

namespace InterpolationConsoleTest
{
    [TestClass]
    public class InterpolationConsoleTest
    {
        [TestMethod]
        public void TestLogLevel()
        {
            var log = new Logger();
            var expected = LogLevel.Error;
            var actual = log.EnabledLevel;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestLogLevelError()
        {
            var log = new Logger();
            var expected = LogLevel.Error;
            var actual = log.EnabledLevel;

            Assert.AreEqual(expected, actual);
        }
    }
}