using System;
using System.Collections.Generic;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            List<char> operators = new List<char>() { '=', '+', '-', '*', '/' };

            Console.WriteLine("Введіть ваш вираз для обробки: ");

            string math = "";
            
            while ( operators.Contains( math[-1] ) || !char.IsDigit(math[-1]) || !operators.Any() ) {
                math += Console.ReadLine();
            }
            
            double result = calc.startCalculation(math);
            Console.WriteLine(result);

            Console.Read();
            
        }
    }
}
