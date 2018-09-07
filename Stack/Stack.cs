using System;
using System.Collections.Generic;

namespace Stack
{
    class Stack
    {
        private List<object> StackArray;

        public Stack()
        {
            StackArray = new List<object>();
        }

        public int Size()
        {
            return StackArray.Count;
        }

        public void Push(object item)
        {
            StackArray.Insert(0, item);
        }

        public object Pop()
        {
            try
            {
                var lastItem = StackArray[0]; 
                StackArray.RemoveAt(0);
                return lastItem;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Стэк пуст! Извлекать нечего!");
                return null;
            }
        }

        public object Peak()
        {
            try
            {
                return StackArray[0];
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Стэк пуст! Последнего элемента не существует!");
                return null;
            }
        }

        public void Write()
        {
            foreach (var e in StackArray)
                Console.Write(e + " ");
            Console.WriteLine();
        }
    }
}
