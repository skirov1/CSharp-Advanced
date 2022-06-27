using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        public List<T> List { get; set; }
        private int index = 0;
        public ListyIterator(List<T> list)
        {
            this.List = list;
        }
        public bool Move()
        {
            if (index + 1 < List.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return index + 1 < List.Count;
        }
        public void Print()
        {
            if (List.Count > 0)
            {
                Console.WriteLine(List[index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}
