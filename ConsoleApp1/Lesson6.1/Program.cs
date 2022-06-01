using Lesson6._1;

public static class Program
{
    public static void Main()
    {
        Point a = new Point(1, 2, "A");
        Point b = new Point(3, 4, "B");
        Point c = new Point(5, 6, "C");
        Point d = new Point(7, 8, "D");

        Polygon triangle = new Polygon(a, b, c, d);
        Console.WriteLine(triangle.Perimeter().ToString());
    }
}