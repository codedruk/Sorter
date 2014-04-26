namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Selection
    {
        public int[] arrayToSort;

        public System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

        public void sort()
        {
            stopWatch.Start();
            selection();
            stopWatch.Stop();
        }

        void selection()
        {
            int min, temp;
            int i, j;
            int arrayLength = arrayToSort.Length;
            for (j = 0; j < arrayLength - 1; j++)
            {
                min = j;
                for (i = j + 1; i < arrayLength; i++)
                {
                    if (arrayToSort[i] < arrayToSort[min])
                        min = i;
                }
                if (min != j)
                {
                    temp = arrayToSort[min];
                    arrayToSort[min] = arrayToSort[j];
                    arrayToSort[j] = temp;
                }
            }
        }
    }
}
