namespace _1768_MergestringAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1=Console.ReadLine();
            string str2=Console.ReadLine();

           string result= megrgeString(str1, str2);

            Console.WriteLine(result);
        }

        public static string megrgeString(string words1,string words2)
        {
            string result = "";

            int len1= words1.Length;    
            int len2= words2.Length;

            int count = 0;
            for (int i = 0; i < len1; i++) 
            {
                result += words1[i].ToString() + words2[i].ToString();
                count++;
                if(count == len2) {
                    break;
                }
            }
            if(len1>len2) {
                result = result + words1.Substring(len2, len1 - len2);

            }
            else if(len2 > len1) {
                result = result + words2.Substring(len1,len2-len1);

            }
           return result;
        }
    }
}
