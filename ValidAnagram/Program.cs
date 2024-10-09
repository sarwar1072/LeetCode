using System.Text.RegularExpressions;

namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string str1=Console.ReadLine();
            string str2=Console.ReadLine();

            bool bl= ValidAnagramMethod(str1 , str2);
            Console.WriteLine(bl);
        }
        public static bool ValidAnagramMethod(string s,string t) 
        {
            var list=new List<char>(s);

            int count = 0;
            if(s.Length != t.Length) {
                return false;
            }
            foreach (char c in t)
            {
                if(list.Remove(c))
                    count++;    
            }
            if(list.Count == 0)
            {
                return true;    
            }
            else
            {
                return false;   
            }
        }
    }
}
