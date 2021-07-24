using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class TemperatureConversion
    {
        public void TempConversion()
        {
            Console.Write("\n1. Celsius to Fahrenheit\n2. Fahrenheit to Celsius\nSelect Which Conversion Type You Need: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("\nGive the Temperature in Celsius: ");
                    double celsius = Convert.ToInt32(Console.ReadLine());
                    double conversion = (celsius * 9/5) + 32;
                    Console.WriteLine("\n" + celsius + "° C = " + conversion + "° F");
                    break;
                case 2:
                    Console.Write("\nGive the Temperature in Fahrenheit: ");
                    double fahrenheit = Convert.ToInt32(Console.ReadLine());
                    double conversion2 = (fahrenheit - 32) * 5/9;
                    Console.WriteLine("\n" + fahrenheit + "° F = " + conversion2 + "° C");
                    break;
            }

        }
    }
}
