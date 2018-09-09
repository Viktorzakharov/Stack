using System;

namespace Stack
{
    class PostfixExpression
    {
        public static double Solve(string[] expression)
        {
            var allValues = new Stack();
            var numbersValues = new Stack();

            for (int i = expression.Length - 1; i >= 0; i--)
                allValues.Push(expression[i].ToString());

            return GetResult(allValues, numbersValues);
        }

        public static double GetResult(Stack allValues, Stack numbersValues)
        {
            while (allValues.Size() > 0)
            {
                var item = allValues.Pop();
                double doubleItem;

                if (double.TryParse((string)item, out doubleItem)) numbersValues.Push(doubleItem);
                else
                {
                    if ((string)item == "+") numbersValues.Push((double)numbersValues.Pop() + (double)numbersValues.Pop());
                    else if ((string)item == "-") numbersValues.Push((double)numbersValues.Pop() - (double)numbersValues.Pop());
                    else if ((string)item == "*") numbersValues.Push((double)numbersValues.Pop() * (double)numbersValues.Pop());
                    else if ((string)item == "/") numbersValues.Push((double)numbersValues.Pop() / (double)numbersValues.Pop());
                    else if ((string)item == "=") break;
                }
            }
            return (double)numbersValues.Pop();
        }
    }
}
