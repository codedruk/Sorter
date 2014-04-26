namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Insertion
    {
        public int[] arrayToSort;

        public System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

        public void sort()
        {
            stopWatch.Start();
            insertion();
            stopWatch.Stop();
        }

        void insertion()
        {
            int arrayLength = arrayToSort.Length;
            int x, temp;
            for (int i = 0; i < arrayLength; i++)
            {
                x = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arrayToSort[i - x] < arrayToSort[j])
                    {
                        temp = arrayToSort[i - x];
                        arrayToSort[i - x] = arrayToSort[j];
                        arrayToSort[j] = temp;
                        x++;
                    }
                    else
                        break;
                }
            }
        }
    }
}
