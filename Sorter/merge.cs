namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Merge
    {
        public int[] arrayToSort;

        public System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

        public void sort()
        {
            stopWatch.Start();
            int arrayLength = arrayToSort.Length - 1;
            mergeSort(0, arrayLength);
            stopWatch.Stop();
        }

        private void mergeSort(int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(p, q);
                mergeSort(q + 1, r);
                merge(p, q, r);
            }
        }

        private void merge(int p, int q, int r)
        {
            int i, j;
            int l = q - p + 1;
            int m = r - q;
            int[] L = new int[l + 1];
            int[] R = new int[m + 1];

            for (i = 0; i < l; i++)
                L[i] = arrayToSort[p + i];
            for (j = 0; j < m; j++)
                R[j] = arrayToSort[q + j + 1];

            L[l] = R[m] = int.MaxValue;

            i = j = 0;
            for (int k = p; k < r + 1; k++)
            {
                if (L[i] <= R[j])
                {
                    arrayToSort[k] = L[i++];
                }
                else
                {
                    arrayToSort[k] = R[j++];
                }
            }
        }
    }
}
