using NUnit.Framework;
using System;
using System.Linq;
using Snail;

namespace SnailTest
{
    public class Tests
    {
        [Test]
        public void SnailTest1()
        {
            int[][] array =
            {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };
            //var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            var r = new[] { 3, 2, 1, 4, 5, 6, 9, 8, 7 };
            Assert.That(SnailSolution.Snail(array), Is.EqualTo(1));
            //Test(array, r);
        }
    }
}