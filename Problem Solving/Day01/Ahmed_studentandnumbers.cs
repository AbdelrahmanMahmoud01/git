using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.Day01
{
    public static class Ahmed_studentandnumbers
    {
        public static string studentandnumber(long Num01, long Num02)
        {
            if (Num01 < Num02)
            {
                return ("first");
            }
            else if (Num01 > Num02)
            {
                return ("second");
            }
            else
            {
                return ("Equal");
            }
        }
    }
}