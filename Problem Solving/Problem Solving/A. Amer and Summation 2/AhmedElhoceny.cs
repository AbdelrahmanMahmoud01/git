using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.A._Amer_and_Summation_2
{
    class AhmedElhoceny
    {
        void A._Amer_and_Summation_2()
        {
            var Character = Console.ReadLine();
            var ArrayData = Character.Split(" ");
            var FirstStep = double.Parse(ArrayData[0]);
            var LastStep = double.Parse(ArrayData[1]);
            double FinalResult = 0;

            for (double i = FirstStep; i <= LastStep; i++)
            {
                FinalResult += i;
            }

            Console.WriteLine(FinalResult);
        }
    }
}
