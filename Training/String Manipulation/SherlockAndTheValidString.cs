using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.String_Manipulation
{
    class SherlockAndTheValidString
    {
        public SherlockAndTheValidString()
        {
            string s = "aabbcd";
            SherlockAndTheValidString.isValid(s);
        }

        static string isValid(string s)
        {
            int[] a = new int[s.Length];
            string result = "YES";

            for(int i = 0; i < s.Length; i++)
            {
                a[i] = s.Where(x => x == s[i]).Count();
            }

            return result;
        }
    }
}
