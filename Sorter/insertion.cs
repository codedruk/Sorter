namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Insertion
    {
        public int[] A; //array to sort or sorted array

        public System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        public void sort()
        {
            sw.Start();
            insertion();
            sw.Stop();
        }

        void insertion()
        {
            int n = A.Length;
            int x, temp;
            for (int i = 0; i < n; i++)
            {
                x = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (A[i - x] < A[j])
                    {
                        temp = A[i - x];
                        A[i - x] = A[j];
                        A[j] = temp;
                        x++;
                    }
                    else
                        break;
                }
            }
        }
    }
}
