using System.Diagnostics;

namespace FindDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();  

            string str2=Console.ReadLine();

            char c= IsDifference(str, str2);

            Console.WriteLine(c) ;
        }
        public static char IsDifference(string s,string t)
        {
            var list=new List<char>(t);
            char ch = ' ';
            foreach(char c in s)
            {
                if (list.Remove(c))
                {
                    continue;
                }
            }
            ch = list.ToArray()[0];
            if(list != null) {
                return ch;
            }
            return ch;
        }
    }
}
