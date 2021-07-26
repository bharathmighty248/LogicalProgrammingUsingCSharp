using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class MonthlyPayment
    {
        public void Monyhlypayment()
        {
            Console.WriteLine("\nGive the Below Details");

            Console.Write("\nPrincipal Loan Amount: ");
            double principalP = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nYears to Pay: ");
            double yearsY = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nRate of Interest: ");
            double rateOfInterestR = Convert.ToDouble(Console.ReadLine());

            //Calculation
            double n = 12 * yearsY;
            double r = rateOfInterestR / (12 * 100);
            double payment = (principalP * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("\nMonthly Payment = Rs." + payment);
        }
    }
}