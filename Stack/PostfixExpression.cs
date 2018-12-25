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
                values.push(expression[i].ToString());

            return GetResult(values, numbers);
        }

        static double GetResult(Stack<string> values, Stack<string> numbers)
        {
            var symbols = "+-*/%=";
            while (values.size() > 0)
            {
                var item = values.pop();
                if (double.TryParse(item, out double doubleItem)) numbers.push(doubleItem.ToString());
                else if (symbols.Contains(item))
                {
                    if (numbers.size() < 1) return default(double);
                    if (item == "=") break;
                    if (numbers.size() < 2) return default(double);
                    numbers.push(Eval(numbers.pop() + item + numbers.pop()));
                }
            }
            if (numbers.size() < 1) return default(double);
            return double.Parse(numbers.pop());
        }

        static string Eval(string expression)
        {
            var table = new DataTable();
            return table.Compute(expression, string.Empty).ToString();
        }
    }
}
