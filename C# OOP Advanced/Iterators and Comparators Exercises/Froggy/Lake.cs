using System.Collections;
using System.Collections.Generic;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] elements)
        {
            this.stones = new List<int>(elements);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }

            if (this.stones.Count % 2 != 0)
            {
                for (int i = this.stones.Count - 2; i > 0; i -= 2)
                {
                    yield return this.stones[i];
                }
            }
            else
            {
                for (int i = this.stones.Count - 1; i > 0; i -= 2)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
