namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class bubble
    {
        public int[] arrayToSort; //array to sort or sorted array

        public System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();


        public void sort()
        {
            stopWatch.Start();
            bubble_sort();
            stopWatch.Stop();
        }

        private void bubble_sort()
        {
            bool check = true;
            int temp, arrayLength = arrayToSort.Length - 1, i, j;
            while (check)
            {
                check = false;
                for (i = 0; i < arrayLength; i++)
                {
                    j = i + 1;
                    if (arrayToSort[i] > arrayToSort[j])
                    {
                        temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[j];
                        arrayToSort[j] = temp;
                        check = true;
                    }
                }
                arrayLength--;
            }
        }
    }
}
