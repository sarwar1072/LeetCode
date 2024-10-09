namespace FirstUniqueChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str=Console.ReadLine();
           //int ind= IsFirstUnique(str);
           // Console.WriteLine(ind);
          int id=  FirstUniqChar(str);
            Console.WriteLine(id);
        }

        public static int IsFirstUnique(string str)
        {
            var uniqueSet= new HashSet<char>();
            var DuplicateSet=new HashSet<char>();
            var CharIndMap = new Dictionary<char, int>();

            
            for(int i=0; i<str.Length;i++)
            {  
                char ch = str[i];   
                if (uniqueSet.Contains(ch))
                {
                    DuplicateSet.Add(ch);
                }
                else
                {
                    uniqueSet.Add(ch);
                    CharIndMap[ch] = i;
                }
            }
            uniqueSet.ExceptWith(DuplicateSet);  

           if(uniqueSet.Count > 0) { 
            int ind = CharIndMap[uniqueSet.First()];
                return ind;

            }
            return -1;            
        }
        public static int FirstUniqChar(string s)
        {
            int n = s.Length;
            if (n == 0)
            {
                return -1;
            }
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else
                {
                    charCount[ch] = 1;
                    Console.WriteLine(charCount);
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
