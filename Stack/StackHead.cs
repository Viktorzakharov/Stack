namespace AlgorithmsDataStructures
{
    public class StackHead<T>
    {
        public LinkedList2<T> StackList;

        public StackHead()
        {
            StackList = new LinkedList2<T>();
        }

        public int size()
        {
            return StackList.GetLength();
        }

        public T pop()
        {
            var node = StackList.RemoveHead();
            if (node == null) return default(T);
            return node.value;
        }

        public void push(T item)
        {
            StackList.AddNodeInHead(new Node<T>(item));
        }

        public T peak()
        {
            if (StackList.GetHead() == null) return default(T);
            return StackList.GetHead().value;
        }
    }
}
