using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class JumpingOnClouds
    {
        public JumpingOnClouds()
        {
            //int[] array = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            int[] array = new int[] { 0, 0, 0, 1, 0, 0 };
            
            int result = jumpingOnClouds(array);
        }

        static int jumpingOnClouds(int[] c)
        {
            int steps = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    steps++;
                    i++;
                }
                else if (i + 1 < c.Length && c[i + 1] == 0)
                {
                    steps++;
                }
            }

            return steps;
        }
    }
}
