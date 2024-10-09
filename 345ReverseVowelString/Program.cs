using System.Text;

namespace _345ReverseVowelString
{
    internal class Program
    {
        static void Main(string[] args)
        {
              var input=Console.ReadLine();
            var output = ReverseString(input);
            Console.WriteLine(output);  
        }

        public static string ReverseString(string input)
        {
            var str = new StringBuilder();
            var st=new Stack<char>();

            foreach(var c in input)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    st.Push(c);
                }    
            }

            foreach (var item in input)
            {
                if("aeiouAEIOU".Contains(item)) 
                { 
                    str.Append(st.Pop());
                }
                else
                {
                    str.Append(item);
                }

            }
            return str.ToString();  
        }
    }
}
