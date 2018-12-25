using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Stack<T>
    {
        public List<T> StackArray;

        public Stack()
        {
            StackArray = new List<T>();
        }

        public int size()
        {
            return StackArray.Count;
        }

        public T pop()
        {
            if (StackArray.Count <= 0) return default(T);
            var item = StackArray[StackArray.Count - 1];
            StackArray.RemoveAt(StackArray.Count - 1);
            return item;
        }

        public void push(T item)
        {
            StackArray.Add(item);
        }

        public T peak()
        {
            if (StackArray.Count <= 0) return default(T);
            return StackArray[StackArray.Count - 1];
        }
    }
}
