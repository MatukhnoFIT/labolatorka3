using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите пример:");
                    string line = Console.ReadLine();
                    try
                    {
                        Calculator calculator = new Calculator(line);
                        calculator.Calculating(calculator);
                    }
                    catch (IndexOutOfRangeException)
                    {

                        double line1 = Convert.ToDouble(line);
                        char action = Convert.ToChar(Console.ReadLine());
                        double line2 = Convert.ToDouble(Console.ReadLine());

                        if (action == '+') {
                            Console.WriteLine("Ответ: " + (line1 + line2));
                        }
                        else if (action == '-')
                        {
                            Console.WriteLine("Ответ: " + (line1 - line2));
                        }
                        else if (action == '*')
                        {
                            Console.WriteLine("Ответ: " + (line1 * line2));
                        }

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Не верный пример");
                }
                Console.ReadLine();
            }
        }

    }
}
