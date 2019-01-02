using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.String_Manipulation
{
    class MakeAnagram
    {
        public MakeAnagram()
        {
            //string a = "cde";
            //string b = "abc";

            string a = "fcrxzwscanmligyxyvym";
            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            MakeAnagram.makeAnagram(a, b);
        }

        static int makeAnagram(string a, string b)
        {
            List<string> A = a.Select(x => x.ToString()).ToList();
            List<string> B = b.Select(x => x.ToString()).ToList();
            int count = 0;
            bool flag;

            foreach (var itemA in A)
            {
                flag = true;
                foreach (var itemB in B)
                {
                    if(itemA == itemB)
                    {
                        B.Remove(itemB);
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    count++;
                }
            }

            count += B.Count();

            return count;
        }
    }
}
