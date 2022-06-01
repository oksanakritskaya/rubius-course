using System;

namespace Lesson6._1
{
    internal class Polygon
    {
        private Point _point1 { get; }
        private Point _point2 { get; }
        private Point _point3 { get; }
        private Point _point4 { get; }
        private Point _point5 { get; }


        public Polygon(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        public Polygon(Point point1, Point point2, Point point3, Point point4)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
        }

        public Polygon(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
            _point5 = point5;
        }

        public double Perimeter()
        {
            double result = SideLength(_point1, _point2) + SideLength(_point2, _point3);
            Point lastPoint = _point3;

            if (_point4 != null)
            {
                result += SideLength(_point3, _point4);
                lastPoint = _point4;
            }

            if (_point5 != null)
            {
                result += SideLength(_point4, _point5);
                lastPoint = _point5;
            }

            return result + SideLength(lastPoint, _point1);
        }

        private double SideLength(Point point1, Point point2)
        {
            return Math.Sqrt((Math.Pow(point2.X - point1.X, 2)) + (Math.Pow(point2.Y - point1.Y, 2)));
        }
    }
}
