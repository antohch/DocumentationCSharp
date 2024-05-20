using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Snail;

namespace SnailTestF
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[][] array =
{
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };
            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            Assert.AreEqual(r, SnailSolution.Snail(array));
        }
    }
}
