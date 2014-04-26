namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class bubble
    {
        public int[] A; //array to sort or sorted array

        public System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();


        public void sort()
        {
            sw.Start();
            bubble_sort();
            sw.Stop();
        }

        private void bubble_sort()
        {
            bool f = true;
            int temp, n = A.Length - 1, i, j;
            while (f)
            {
                f = false;
                for (i = 0; i < n; i++)
                {
                    j = i + 1;
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        f = true;
                    }
                }
                n--;
            }
        }
    }
}
