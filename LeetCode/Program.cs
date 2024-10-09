using System.Threading.Channels;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int n = MissingNumber(arr);
            Console.WriteLine(n);

        }
        public static int MissingNumber(int[] arr)
        {
            Array.Sort(arr);
            int n = arr.Length;

            if (arr[0] != 0)
                return 0;

            if (arr[n - 1] != n)
                return n;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != i)
                    return i;
            }

            return 0;
        }


    }
}
