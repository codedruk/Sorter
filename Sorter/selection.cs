namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Selection
    {
        public int[] A; //array to sort or sorted array

        public System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        public void sort()
        {
            sw.Start();
            selection();
            sw.Stop();
        }

        void selection()
        {
            int min, temp;
            int i, j;
            int n = A.Length;
            for (j = 0; j < n - 1; j++)
            {
                min = j;
                for (i = j + 1; i < n; i++)
                {
                    if (A[i] < A[min])
                        min = i;
                }
                if (min != j)
                {
                    temp = A[min];
                    A[min] = A[j];
                    A[j] = temp;
                }
            }
        }
    }
}
