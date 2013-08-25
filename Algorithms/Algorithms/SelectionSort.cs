namespace Algorithms
{
    public class SelectionSort
    {
        public int[] Sort(int[] unsorted)
        {
            if (unsorted.Length == 1)
            {
                return unsorted;
            }

            for (int i = 0; i < unsorted.Length; i++)
            {
                var smallest = i;
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    if (unsorted[smallest] > unsorted[j])
                    {
                        smallest = j;
                    }

                    if (unsorted[i] > unsorted[smallest])
                    {
                        Swap(unsorted, i, smallest);
                    }
                }
            }

            return unsorted;
        }

        public void Swap(int[] list, int i, int smallest)
        {
            list[i] = list[i] + list[smallest];
            list[smallest] = list[i] - list[smallest];
            list[i] = list[i] - list[smallest];
        }
    }
}
