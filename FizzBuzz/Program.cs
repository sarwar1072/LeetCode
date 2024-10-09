using System.Numerics;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> str = FizzStrng(num);

            foreach (var str2 in str)
            {
                Console.WriteLine($"{str2}");
            }
        }

        public static List<string> FizzStrng(int n)
        {
            List<string> result = new();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add($"{i}");
                }
            }

            return result;
        }
    }
}
