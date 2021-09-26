using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Calculator
    {



        public double startCalculation(string math)
        {
            math = math.Replace(" ", "").Replace(" ", "").Replace("=", "");

            Console.WriteLine(math);

            return 0.0;
        }
    }
}
