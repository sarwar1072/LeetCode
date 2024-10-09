using static System.Net.Mime.MediaTypeNames;
namespace LengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1=Console.ReadLine();

            int index = LengthOfLastWord(str1);
          
            Console.WriteLine(index);         
        }
        public static int LengthOfLastWord(string str)
        {
            string str2 = str.Trim();
            int length = 0; 
            for (int i = str2.Length-1; i >=0 ; i--)
            {
                if (str2[i] != ' ')
                {
                    length++;
                }
                else if (length >0)
                {
                    break;
                }
            }          
            return length;
        }
    }
}
