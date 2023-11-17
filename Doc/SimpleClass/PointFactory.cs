using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public class PointFactory
    {
        private int numberOfPoints;
        public PointFactory(int numberOfPoints) 
        {
            this.numberOfPoints = numberOfPoints;
        }
        public IEnumerable<Point> CreatePoints()
        {
            var generator = new Random();
            for (int i = 0; i < numberOfPoints; i++)
            {
                yield return new Point(generator.Next(),generator.Next());
            }
        }
    }
}
