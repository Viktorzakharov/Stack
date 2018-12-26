using System.Data;

namespace AlgorithmsDataStructures
{
    public class PostfixExpression
    {
        public static double Solve(string expression)
        {
            var expressionArray = expression.Split(' ');
            var values = new Stack<string>();
            var numbers = new Stack<string>();

            for (int i = expression.Length - 1; i >= 0; i--)
                values.Push(expression[i].ToString());

            return GetResult(values, numbers);
        }

        static double GetResult(Stack<string> values, Stack<string> numbers)
        {
            var symbols = "+-*/%=";
            while (values.Size() > 0)
            {
                var item = values.Pop();
                if (double.TryParse(item, out double doubleItem)) numbers.Push(doubleItem.ToString());
                else if (symbols.Contains(item))
                {
                    if (numbers.Size() < 1) return default(double);
                    if (item == "=") break;
                    if (numbers.Size() < 2) return default(double);
                    numbers.Push(Eval(numbers.Pop() + item + numbers.Pop()));
                }
            }
            if (numbers.Size() < 1) return default(double);
            return double.Parse(numbers.Pop());
        }

        static string Eval(string expression)
        {
            var table = new DataTable();
            return table.Compute(expression, string.Empty).ToString();
        }
    }
}
