using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    public class Pyramid : Shape
    {
        public double Square { get; set; }
        public double Height { get; set; }

        public Pyramid(double square, double height)
        {
            Square = square;
            Height = height;
        }
        public override double Volume()
        {
            return Square * Height / 3;
        }
    }
}
