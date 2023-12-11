using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    internal class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public bool Equals(Car other)
        {
            return (this.Make, this.Model, this.Year) == (other?.Make, other?.Model, other?.Year);
        }
    }
}
