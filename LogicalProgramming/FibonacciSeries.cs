using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class FibonacciSeries
    {
        public void Fibonacci()
        {
            int element1 = 0, element2 = 1;
            int nextElement = 0;
            Console.Write("\nEnter the Number of Elements You Want To Print in Fibonacci Series: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n" + element1 + " " + element2 + " ");  //Printing 0 and 1 Initially
            for (int i=2; i<elements; i++)    //Loop Starts From 2 Because 0 and 1 are Already Printed 
            {
                nextElement = element1 + element2;
                Console.Write(nextElement + " ");
                element1 = element2;
                element2 = nextElement;
            }
            Console.WriteLine();
        }
    }
}
