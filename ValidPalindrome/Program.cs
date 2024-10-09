using System.Text;
namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();

            var str= Ispalindrome(s);
            Console.WriteLine(str);
        }
        public static bool Ispalindrome(string s) 
        {
            var str = new StringBuilder();

            string revs = "";

            foreach (var item in s.ToLower())
            {
                if (char.IsLetterOrDigit(item))
                {
                    str.Append(item);   
                }
            }
            string str2 = str.ToString();

            for(int i = str2.Length - 1; i >= 0; i--)
            {
                revs += str2[i];
            }

            if(revs == str2)
            {
                return true;    
            }
            return false;   
      
        }
    }
}
