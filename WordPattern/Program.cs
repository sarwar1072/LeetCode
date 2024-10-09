namespace WordPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern=Console.ReadLine(); 
            var s=Console.ReadLine();

            var result= WordPattern(pattern, s);

            Console.WriteLine(result);
        }
        public static bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            string[] str = s.Split(" ");
            if (pattern.Length != str.Length)
            {
                return false;
            }
            for (int i = 0; i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]))
                {
                    if (dict[pattern[i]] != str[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsValue(str[i]))
                    {
                        return false;
                    }
                    dict.Add(pattern[i], str[i]);
                }
            }
            return true;
        }

        public static bool WordPattern2(string pattern, string s)
        {
            var split = s.Split(" ");
            if (pattern.Length != split.Length)
            {
                return false;
            }
            for (int i = 0; i < pattern.Length; i++)
            {
                int pIdx = pattern.IndexOf(pattern[i]);
                int sIdx = Array.IndexOf(split, split[i]);
                if (pIdx != sIdx)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
