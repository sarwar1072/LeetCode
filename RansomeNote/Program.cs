namespace RansomeNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string note=Console.ReadLine();
            string msg=Console.ReadLine();

            bool st=RansomeNoteFunstion(note,msg);
            Console.WriteLine(st);
        }
        public static bool RansomeNoteFunstion(string note,string msg) 
        {
            var list=new List<char>(note);
            int count = 0;
            foreach(char c in msg)
            {
                if(list.Remove(c))
                {
                    count++;
                } 
            }
             return note.Length == count;
        }
    }
}
