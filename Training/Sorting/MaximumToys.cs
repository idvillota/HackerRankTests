using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Sorting
{
    class MaximumToys
    {
        public MaximumToys()
        {
            int[] prices = new int[] { 1, 12, 5, 111, 200, 1000, 10 };
            int k = 50;
            int result = MaximumToys.MaximumToysMethod(prices, k);
            
        }

        public static int MaximumToysMethod(int[] prices, int k)
        {
            Array.Sort(prices);
            int max = 0;
            int count = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                if(max + prices[i] <= k)
                {
                    max += prices[i];
                    count ++;
                }
            }

            return count;
        }
    }
}
