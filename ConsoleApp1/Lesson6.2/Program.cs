using Lesson6._2;

public static class Program
{
    public static void Main()
    {
        Box box = new Box(300);

        Ball ball = new Ball(150);
        Cylinder cylinder = new Cylinder(20, 15);
        Pyramid pyramid1 = new Pyramid(100, 200);
        Pyramid pyramid2 = new Pyramid(1000000, 2000000);

        box.Add(ball);
        box.Add(cylinder);
        box.Add(pyramid1);
        box.Add(pyramid2);
    }
}