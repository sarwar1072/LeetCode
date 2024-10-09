namespace FirstOccStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1=Console.ReadLine();

            string str2=Console.ReadLine();

            int index=FirstOccurrenceOfSubstring(str1,str2);

            Console.WriteLine(index);

        }

        public static int FirstOccurrenceOfSubstring(string str1, string str2)
        {
            int index = str1.Length;
            int index2 = str2.Length;

            int i;
            for ( i = 0; i <= index - index2; i++)
            {

                int j;

                for (j = 0; j < index2; j++)
                {

                    if (str1[i + j] != str2[j])
                    {
                        break;
                    }
                }
                if (j == index2)
                {
                    return i;
                }
            }
            return -1;  
        }
    }
}
