using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.StudentAndNumbers
{
    public class AhmedElhoceny
    {
        public string Compare()
        {
            var StringInput = Console.ReadLine();
            var CheckDataArray = StringInput.split(" ");
            if (double.parse(CheckDataArray[0]) > double.parse(CheckDataArray[1]))
            {
                Console.WriteLine(">");
            }
            else if (double.parse(CheckDataArray[0]) < double.parse(CheckDataArray[1]))
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
