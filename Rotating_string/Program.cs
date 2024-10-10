namespace Rotating_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1=Console.ReadLine(); 

            string str2=Console.ReadLine();

            bool bl= RotateAndCompare(str1, str2);

            Console.WriteLine(bl);
        }
        public static bool RotateAndCompare(string s, string goal)
        {
            if (s.Length != goal.Length)
            {
                return false;
            }
            if (s == goal)
            {
                return true;
            }
            char[] chars = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                RotateLeft(chars);
              // Convert the rotated character array back to a string.
                string rotatedString = new string(chars);
                // Check if the rotated string matches the goal.
                if (rotatedString == goal)
                {
                    return true;
                }
            }
            return false;
        }
        private static void RotateLeft(char[] chars)
        {
            char firstChar = chars[0];
            for (int i = 0; i < chars.Length - 1; i++)
            {
                chars[i] = chars[i + 1];
            }
            chars[chars.Length - 1] = firstChar;
        }

    }
}
