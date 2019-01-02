using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class RepeatedString
    {
        public RepeatedString()
        {
            //string input = "aba";
            //long len = 10; //Result: 7

            string input = "gfcaaaecbg";
            long len = 547602; // Result: 164280

            //string input = "udjlitpopjhipmwgvggazhuzvcmzhulowmveqyktlakdufzcefrxufssqdslyfuiahtzjjdeaxqeiarcjpponoclynbtraaawrps";
            //long len = 872514961806; // Result:69801196944

            long result = RepeatedString.repeatedString(input, len);
        }

        static long repeatedString(string s, long n)
        {
            int index = 0;
            int count = 0;
            bool aux = true;
            long total = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] != 'a')
                {
                    aux = false;
                }
            }

            if (aux)
            {
                return n;
            }


            for(int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('a'))
                {
                    count++;
                }
            }

            var x = n / s.Length;
            var z = n % s.Length;

            total = x * count;

            for (int i = 0; i < z; i++)
            {
                if (s[i].Equals('a'))
                {
                    total++;
                }
            }

            return total;
        }
    }
}
