namespace MatchParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Take input: ");

            string str = Console.ReadLine();

            if (IsBalance(str))
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("not matched");
            }
        }

        static bool IsBalance(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var item in str)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == '}' || item == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var top = stack.Pop();
                    if ((top == '(' && item == ')') || (top == '{' && item == '}') || (top == '[' && item == ']'))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
