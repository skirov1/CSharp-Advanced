using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        List<T> boxes = new List<T>();
        public void Add(T element)
        {
            boxes.Add(element);
        }
        public T Remove()
        {
            var element = boxes[boxes.Count - 1];
            boxes.RemoveAt(boxes.Count - 1);
            return element;
        }
        public int Count => boxes.Count;      
    }
}
