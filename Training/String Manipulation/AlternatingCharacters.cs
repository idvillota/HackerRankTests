using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.String_Manipulation
{
    class AlternatingCharacters
    {
        public AlternatingCharacters()
        {
            //string s = "AAAA";              //Result =3
            //string s = "BBBBB";           //Result =4
            //string s = "ABABABAB";        //Result =0
            //string s = "BABABA";          //Result =0
            string s = "AAABBB";          //Result =4
            AlternatingCharacters.alternatingCharacters(s);
        }

        static int alternatingCharacters(string s)
        {
            char c;
            char p;
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                c = s[i];
                if (i > 0)
                {
                    p = s[i - 1];
                    if(c == p)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
