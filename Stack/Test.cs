using System;

namespace Stack
{
    class Test
    {
        public static void Test1(Stack stack)
        {
            var rnd = new Random();

            for (int i = 0; i < 7; i++)
                stack.Push(rnd.Next(255));
            stack.Write();

            for (int i = 0; i < 4; i++)
                stack.Pop();
            stack.Write();

            for (int i = 0; i < 4; i++)
                stack.Pop();
            stack.Write();

            Console.WriteLine(stack.Peak());

        }

        public static void Test2(Stack stack)
        {
            stack.Push("hello");
            stack.Push(true);
            stack.Push(25.47);

            stack.Write();
            Console.WriteLine(stack.Pop());
            stack.Write();
        }

        public static void BracketsBalance(string[] lines)
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
                FindBracketsBalance.BracketsBalance(line);
            }
            Console.WriteLine();
        }

        public static void PostfixExpressionSolve(string[] lines)
        {
            foreach (var item in lines)
                Console.Write(item);

            Console.WriteLine();
            Console.WriteLine(PostfixExpression.Solve(lines));
        }
    }
}
