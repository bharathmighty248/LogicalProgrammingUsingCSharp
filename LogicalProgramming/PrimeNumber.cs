using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class PrimeNumber
    {
        public void PrimeNumberCheck()
        {
            int count = 0;
            Console.Write("\nEnter the Number To Check Prime Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            if (count == 2)
            {
                if (number == 2)
                    Console.WriteLine("\n" + number + " is the Only Even Prime Number");
                else
                    Console.WriteLine("\n" + number + " is a Prime Number");
            }
            else
                Console.WriteLine("\n" + number + " is Not a Prime Number");
        }
    }
}
