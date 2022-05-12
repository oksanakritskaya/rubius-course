using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string getValues()
        {
            return $"({x}, {y}, {z})";
        }

        public double getVectorLength()
        {
            return Math.Sqrt(getSecondPow(this.x) + getSecondPow(this.x) + getSecondPow(this.x));
        }

        public double getScalarMultiplication(Vector b)
        {
            return x * b.x + y * b.y + z * b.z;
        }

        public Vector getVectorMultiplication(Vector b)
        {
            return new Vector(y * b.z - z * b.y, z * b.x - x * b.z, x * b.y - y * b.x);
        }

        public double getAngle(Vector b)
        {
            return getScalarMultiplication(b) / getVectorLength() * b.getVectorLength();
        }

        public Vector getSum(Vector b)
        {
            return new Vector(x + b.x, y + b.y, z + b.z);
        }

        public Vector getDiff(Vector b)
        {
            return new Vector(x - b.x, y - b.y, z - b.z);
        }

        private double getSecondPow(double value)
        {
            return Math.Pow(value, 2);
        }
    }
}
