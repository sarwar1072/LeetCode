namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "flow", "flo", "flowless","flowww" };
           string prefix= LongestCommonPrefix( str);
            Console.WriteLine(prefix.Length);
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string str = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(str) != 0)
                {
                    str=str.Substring(0, str.Length-1);

                    if (str == null)
                        return "";
                }
            }    
            return str; 
        }
    }
}

