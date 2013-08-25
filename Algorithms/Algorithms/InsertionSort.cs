using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] unsorted)
        {
            int i, j;

            for (i = 1; i < unsorted.Length; i++)
            {
                int value = unsorted[i];
                j = i - 1;

                while ((j >= 0) && (unsorted[j].CompareTo(value) > 0))
                {
                    unsorted[j + 1] = unsorted[j];
                    j--;
                }
                unsorted[j + 1] = value;
            }

            return unsorted;
        }
    }
}
