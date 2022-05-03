namespace Lesson3
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("a: ");
            int a = NormalizeNum(Console.ReadLine());

            Console.Write("action: ");
            string action = Console.ReadLine();

            Console.Write("b: ");
            int b = NormalizeNum(Console.ReadLine());

            Console.WriteLine("____________________");

            int result = Calculate(a, b, action);

            Console.WriteLine($"{result}");
        }

        public static int NormalizeNum(string num = "")
        {
            int result = 0;

            bool success = Int32.TryParse(num, out result);

            return result;
        }

        public static int Calculate(int a, int b, string action = "")
        {
            int result = 0;

            switch (action)
            {
                case "+": 
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "%":
                    result = a % b;
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор");
                    break;
            }

            return result;
        }
    }
}