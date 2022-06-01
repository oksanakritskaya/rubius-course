using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    public class Cylinder : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
}
