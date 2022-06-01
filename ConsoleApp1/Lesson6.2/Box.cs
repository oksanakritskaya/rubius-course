using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    public class Box : Shape
    {
        public double Height { get; set; }

        private double currentVolume = default;
        private List<Shape> ShapeList = new ();

        public Box(double height)
        {
            Height = height;
        }

        public override double Volume()
        {
            return Math.Pow(Height, 3);
        }

        public bool Add(Shape shape)
        {
            double shapeVolume = shape.Volume();

            if (currentVolume + shapeVolume <= Volume())
            {
                currentVolume += shapeVolume;
                ShapeList.Add(shape);
                return true;
            }

            Console.WriteLine(ToString());
            return false;
        }

        public override string ToString()
        {
            return String.Join(", ", ShapeList);
        }
    }
}
