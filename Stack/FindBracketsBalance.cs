namespace AlgorithmsDataStructures
{
    public class FindBracketsBalance
    {
        public static bool BracketsBalance(string line)
        {
            var stack = new Stack<char>();

            foreach (var item in line)
            {
                if (item == '(') stack.push(item);
                else if (item == ')')
                    if (stack.pop() == default(char)) return false;
            }

            if (stack.size() == 0) return true;
            return false;
        }
    }
}
