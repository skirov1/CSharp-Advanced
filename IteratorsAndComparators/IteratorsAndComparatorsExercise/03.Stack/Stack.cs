using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class CustomStack<T> : IEnumerable<int>
    {
        private readonly IList<int> elements;
        private int index;

        public CustomStack()
        {
            this.elements = new List<int>();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        public void Pop()
        {
            index = elements.Count - 1;
            if (elements.Count > 0)
            {
                elements.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }
        public void Push(int element)
        {
            this.elements.Add(element);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
