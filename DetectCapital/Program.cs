using System.Globalization;

namespace DetectCapital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ar = { 5, 1, 15, 20, 25 };
            //int i, j, m;
            //i = ++ar[1];
            //j = ar[1]++;
            //m = ar[i++];
            //Console.WriteLine(i + " " + j+" "+m);
            string str=Console.ReadLine();  
            bool bl=DetectCapitalMethod(str);
            Console.WriteLine(bl);
        }
        public static bool DetectCapitalMethod(string str)
        {
            string upperCae=str.ToUpper();  
            string lowerCae=str.ToLower();
            string oneCap = str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();

            if (str == upperCae)
                return true;    
            else if(str == lowerCae)
                return true;    
            else if (oneCap.Equals(str)  )
                return true;    
            else return false;
        }
    }
}
