using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System;
using System.Threading.Channels;
namespace KeyboardStringRow
{
    internal class Program
    {
//        Given an array of strings words, return the words that can be typed using letters of
//        the alphabet on only one row of American keyboard like the image below.
//    In the American keyboard:
//the first row consists of the characters "qwertyuiop",
//    the second row consists of the characters "asdfghjkl", and
//    the third row consists of the characters "zxcvbnm".
        static void Main(string[] args)
       {
            int len=int.Parse(Console.ReadLine());
            string[] str = new string[len];

            for (int i = 0; i < len; i++)
            {
                str[i] = Console.ReadLine();
            }
            string[] str2= KeyboardStringRowMethod(str);
            foreach (var item in str2)
            {
                Console.WriteLine(item);
            }
        }
        public static string[] KeyboardStringRowMethod(string[] str)
        {
            char[] first = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            char[] second = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            char[] third = { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            var list= new List<string>();

            foreach (var item in str)
            {
                var hashset = new HashSet<char>(item.ToLower().ToCharArray());

                if (hashset.IsSubsetOf(first) || hashset.IsSubsetOf(second) || hashset.IsSubsetOf(third))
                {
                    list.Add(item);
                }  
            }

           return list.ToArray(); 
        }
    }
}
