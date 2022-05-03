namespace Lesson4
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Array size: ");
            int size;

            if (!TryParse(Console.ReadLine(), out size))
            {
                return;
            }

            if (size < 0)
            {
                Console.WriteLine("Size of array should be > 0");
                return;
            }

            int[] array = new int[size];
            int i = 0;

            bool isParsed = false;

            while (i < array.Length)
            {
                Console.Write($"{i}: ");
                int res;

                isParsed = TryParse(Console.ReadLine(), out res);

                if (isParsed)
                {
                    Console.WriteLine("Success");
                    array[i] = res;
                    ++i;
                }
                else break;
            }

            if (isParsed)
            {
                Array.Sort<int>(array);

                Console.WriteLine($"Second max value: {array[array.Length - 2]}");
            }
        }

        public static bool TryParse(string initial, out int result)
        {
            result = 0;

            try
            {
                if (initial == "")
                {
                    throw new Exception("Empty value. Enter a number");
                }

                result = Int32.Parse(initial);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Parse error: {initial}. Enter a number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return false;
        }
    }
}