using System.Text;

namespace ReverseWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch=Console.ReadLine();
           string str= ReverseWords(ch);  
            Console.WriteLine(str); 
        }
        public static string ReverseWords(string words)
        {

            var str=words.Split(' '); 
             var str2=str.Reverse();
            var list = "";

            foreach (var word in str2)
            {
                if(string.IsNullOrEmpty(word))
                {
                    continue;
                }                    
                list += " "+ word;

            }
            return list.Trim();
        }
    }
}
