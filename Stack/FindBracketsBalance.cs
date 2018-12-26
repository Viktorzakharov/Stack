namespace AlgorithmsDataStructures
{
    public class FindBracketsBalance
    {
        public static bool BracketsBalance(string line)
        {
            var stack = new Stack<char>();

            foreach (var item in line)
            {
                if (item == '(') stack.Push(item);
                else if (item == ')')
                    if (stack.Pop() == default(char)) return false;
            }

            if (stack.Size() == 0) return true;
            return false;
        }
    }
}
