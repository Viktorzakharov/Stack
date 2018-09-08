using System;

namespace Stack
{
    class FindBracketsBalance
    {
        public static void BracketsBalance(string line)
        {
            var stack = new Stack();

            foreach (var item in line)
            {
                if (item == '(') stack.Push(item);
                else if (item == ')')
                    if (stack.Pop() == null)
                    {
                        Console.WriteLine("Скобки не парные!");
                        return;
                    }
            }

            if (stack.Size() == 0) Console.WriteLine("Скобки парные!");
            else Console.WriteLine("Скобки не парные!");
        }
    }
}
