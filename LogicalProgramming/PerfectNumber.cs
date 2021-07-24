using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class PerfectNumber
    {
        public void PerfectNumberCheck()
        {
            int sum = 0;
            Console.Write("\nEnter The Number To Check Perfect Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int num = number;
            for (int i=1; i<number; i++)  // For Factorization
            {
                if (number % i == 0)     // If it is a Factor
                    sum += i;            // it will be Added for Checking
            }
            if (sum == num)
                Console.WriteLine("\n" + number + " is a Perfect number");
            else
                Console.WriteLine("\n" + number + " is Not a Perfect Number");
        }
    }
}
