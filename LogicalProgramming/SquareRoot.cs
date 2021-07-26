using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class SquareRoot
    {
        public void SqRtNewton()
        {
            Console.Write("\nGive the Number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = c;
            long epsilon = (long)1e-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine("\nSquareRoot of " + c + " = " + t);
        }
    }
}
