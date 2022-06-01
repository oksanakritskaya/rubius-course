using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    public class Ball : Shape
    {
        public double Radius { get; set; }

        public Ball(double radius)
        {
            Radius = radius;
        }

        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
