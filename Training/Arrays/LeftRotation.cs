
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Arrays
{
    class LeftRotation
    {
        public LeftRotation()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int rotations = 4;
            LeftRotation.rotLeft(array, rotations);
        }

        static int[] rotLeft(int[] a, int d)
        {
            int[] result = new int[a.Length];
            int index = 0;

            for(int i = 0; i < a.Length; i++)
            {
                index = a.Length - d + i;
                if (index >= a.Length)
                {
                    index -= a.Length;
                }
                result[index] = a[i];
            }

            return result;
        }
    }
}
