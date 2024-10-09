namespace IsomorphicString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st=Console.ReadLine();   
            string ss=Console.ReadLine();   
            bool s= IsomorphicString(st, ss);
            Console.WriteLine(s);
        }

        public static bool IsomorphicString(string s, string t)
        {
            var dic = new Dictionary<char, char>();

            if (s.Length != t.Length) { return false; }

            for (int i = 0; i < s.Length; i++)
            {
                char ss = s[i];
                char st = t[i];
                if (dic.ContainsKey(ss))
                {
                    if (st != dic[ss])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dic.ContainsValue(st))
                    {
                        return false;
                    }
                    dic.Add(ss, st);
                }

            }
            return true;
        }

    }
}
