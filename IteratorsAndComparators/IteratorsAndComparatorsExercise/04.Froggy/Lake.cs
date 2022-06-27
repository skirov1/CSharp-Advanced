using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;
        public Lake(List<int> list)
        {
            this.stones = new List<int>();
            this.stones = list;
        }
        public IEnumerator<int> GetEnumerator()
        {
            int index = 1;
            for (int i = 0; i < stones.Count; i++)
            {
                if (index % 2 != 0)
                {
                    yield return stones[i];
                }
                index++;
            }
            index = stones.Count;
            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (index % 2 == 0)
                {
                    yield return stones[i];
                }
                index--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
