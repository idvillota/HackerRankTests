using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Sorting
{
    class BubbleSort
    {
        public BubbleSort()
        {
            int[] a = new int[] { 3, 2, 1 };
            BubbleSort.countSwaps(a);
        }

        public static void countSwaps(int[] a)
        {
            int n = a.Length;
            int aux = 0;
            int numSwaps = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        aux = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = aux;
                        numSwaps++;
                    }
                }

            }

            Console.WriteLine("Array is sorted in {0} swaps.", numSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n - 1]);
        }
    }
}
