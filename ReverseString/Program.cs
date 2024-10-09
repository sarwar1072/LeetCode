namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ch=Console.ReadLine();
             ReverseString(ch.ToCharArray());
        }
        public static void ReverseString(char[] ch)
        {
            int left = 0;
            int right = ch.Length;  
            while (left < right)
            {
               char temp = ch[left];
                ch[left] = ch[right-1];
                ch[right-1] = temp;
                left++; 
                right--;    
            }
            Console.WriteLine(ch);
        }
    }
}
