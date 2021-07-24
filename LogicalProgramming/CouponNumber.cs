using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalProgramming
{
    class CouponNumber
    {
        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1111, 10000);
        }
        /// <summary>
        /// In this Coupon Generator Method, I used HashSet to save Distinct Coupons. 
        /// Because Set Doesn't Allow Duplicates.
        /// </summary>
        
        int randomCount = 0;
        public void CouponGenerator()
        {
            Console.Write("\nEnter Num of Coupons Needed: ");
            int numOfCoupons = Convert.ToInt32(Console.ReadLine());
            HashSet<int> distinctCoupon = new HashSet<int>();

            while (distinctCoupon.Count() < numOfCoupons)
            {
                int coupon = RandomNumber();
                distinctCoupon.Add(coupon);
                randomCount++;
            }
            Console.Write("\nDistinct Coupon: [ ");
            foreach (int i in distinctCoupon)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]\n");
            Console.WriteLine("Num of Times Random Number Generated: " + randomCount + "\n");
        }
    }
}
