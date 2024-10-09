namespace NoOfSegmentInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var str=Console.ReadLine();
            int fn=NumberOfSegments(str); 
            Console.WriteLine(fn);  
        }
        public static int NumberOfSegments(string str)
        {
            var splitStr=str.Split(' ');    
            //var num=splitStr.Count();
            int num = 0;
            foreach(var i in splitStr)
            {
                if (!string.IsNullOrWhiteSpace(i))
                {
                    num++;
                }

            }
            return num;
        }
    }
}
