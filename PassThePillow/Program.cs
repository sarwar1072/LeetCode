namespace PassThePillow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int times = int.Parse(Console.ReadLine());

            int a = PassThePillow(num, times);

            Console.WriteLine("Hello, World!"+a);
        }
        public static int PassThePillow(int n, int time)
        {
            int[] arr = new int[n];
            for (int j = 0; j < n; j++)
            {
                arr[j] = j + 1;
            }

            int i = 0;
            while (time > 0)
            {
                while (time > 0 && i < arr.Length - 1)
                {
                    i++;
                    time--;
                }
                while (time > 0 && i > 0)
                {
                    i--;
                    time--;
                }
            }

            return arr[i];
        }
    }

}
