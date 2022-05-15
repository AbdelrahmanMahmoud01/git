using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.Conditions_ii__Amnesia
{
    class AhmedElhoceny
    {
        public void i_Amnesia() {
            var Character = Console.ReadLine();
            string Result = "";
            bool VowelFlag = false;

            if (((int)Character[0] > 64 && (int)Character[0] < 91) || ((int)Character[0] > 96 && (int)Character[0] < 123))
            {
                Result += "Alphabet ";
                string[] Vowels = new string[] { "a", "e", "i", "o", "u" };

                if ((int)Character[0] > 64 && (int)Character[0] < 91)
                {
                    Result += "Upper ";
                }
                else if (((int)Character[0] > 96 && (int)Character[0] < 123))
                {
                    Result += "Lower ";
                }

                foreach (var VowelsItem in Vowels)
                {
                    if (Character[0].ToString() == VowelsItem || Character[0].ToString() == VowelsItem.ToUpper())
                    {
                        VowelFlag = true;
                    }
                }
                if (VowelFlag)
                {
                    Result += "Vowel";
                }
                else
                {
                    Result += "Consonant";
                }
            }
            else
            {
                if ((int)Character[0] > 47 && (int)Character[0] < 58)
                {
                    Result = "Number";
                }
                else
                {
                    Result = "Special";
                }
            }
            Console.WriteLine(Result);
        }
    }
}
