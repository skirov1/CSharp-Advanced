using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T>
        where T : class
    {
        public int Count(List<T> list, T element)
        {
            var count = 0;
            foreach (var item in list)
            {
                if (Comparer<T>.Default.Compare(item, element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
