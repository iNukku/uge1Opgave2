using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge1Opgave2
{
    class Compairer
    {
        static char[] one;
        static char[] two;
        static bool isAcronym = false;

        public static bool compairStrings(string a, string b)
        {
            one = a.ToCharArray();
            two = b.ToCharArray();
            Array.Sort(one);
            Array.Sort(two);

            for (int i = 0; i < a.Length; i++)
            {
                if (one[i] == two[i])
                {
                    isAcronym = true;
                }
                else
                {
                    isAcronym = false;
                    break;
                }
            }

            return isAcronym;
        }
    }
}
