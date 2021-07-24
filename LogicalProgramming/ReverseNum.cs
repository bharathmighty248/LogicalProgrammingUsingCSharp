using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class ReverseNum
    {
        public void Reverse()
        {
            int reverse = 0;
            Console.Write("\nEnter the Number To Reverse: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int num = number;     //To Save User Input for just Showing in Output
            while (number != 0)
            {
                int remainder = number % 10;  
                reverse = (reverse * 10) + remainder;
                number = (number / 10);
            }
            Console.WriteLine("\nReverse of " + num + " = " + reverse);
        }
    }
}
