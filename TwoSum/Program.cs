namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] ar = new int[num];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            int target = int.Parse(Console.ReadLine());
            int[] indices = TwoSum(ar, target); // Store returned indices array

            // Print the indices
            Console.WriteLine("Indices of the two numbers that add up to target:");
            foreach (var index in indices)
            {
                Console.WriteLine(index);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            var list = new List<int>();
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        list.Add(i);
                        list.Add(j);
                        break;
                    }
                }
            }
            return list.ToArray();
        }
    }
}
