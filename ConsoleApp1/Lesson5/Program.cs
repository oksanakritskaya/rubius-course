using Lesson5;

public static class Program
{
    public static void Main()
    {
        Vector vector = new Vector(1, 2, 3);
        Console.WriteLine(vector.getVectorLength());

        Vector vector2 = new Vector(4, 5, 6);
        Console.WriteLine(vector.getScalarMultiplication(vector2));

        Console.WriteLine(vector.getVectorMultiplication(vector2).getValues());

        Console.WriteLine(vector.getAngle(vector2));

        Console.WriteLine(vector.getSum(vector2).getValues());
        Console.WriteLine(vector.getDiff(vector2).getValues());
    }
}