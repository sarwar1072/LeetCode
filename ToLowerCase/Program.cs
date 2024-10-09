namespace ToLowerCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string  bl = DetectCapitalMethod(str);
            Console.WriteLine(bl);
        }
        public static string DetectCapitalMethod(string str) {      

            return str.ToLower();
        }
    }
}
