using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
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
        public string PrintAll()
        {
            return $"{string.Join(" ", List)}";
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < List.Count; i++)
            {
                yield return List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
