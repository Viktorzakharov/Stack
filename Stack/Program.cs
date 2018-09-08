using System;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack();

            Test.Test1(stack);
            Test.Test2(stack);
            Console.WriteLine();

            Test.BracketsBalance(new string[] { "(()((())()))", "(()()(()", "((ab)1(89(9))haj)" });
        }
    }
}
