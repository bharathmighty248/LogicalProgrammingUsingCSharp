using System;

namespace LogicalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programming in C#.. ");
            Console.WriteLine("\n1. Fibonacci Series\n2. Perfect Number\n3. Prime Number\n4. Reverse a Number\n5. Coupon Numbers\n6. StopWatch Simulation\n7. Vending Machine\n8. Day Of Week (Calendar Problem)\n9. Temperatur Conversion\n10. Monthly Payment");
            Console.Write("\nPlease Select One Option From Above: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Fibonacci();
                    break;
                case 2:
                    PerfectNumber number = new PerfectNumber();
                    number.PerfectNumberCheck();
                    break;
                case 3:
                    PrimeNumber number1 = new PrimeNumber();
                    number1.PrimeNumberCheck();
                    break;
                case 4:
                    ReverseNum number2 = new ReverseNum();
                    number2.Reverse();
                    break;
                case 5:
                    CouponNumber number3 = new CouponNumber();
                    number3.CouponGenerator();
                    break;
                case 6:
                    
                    break;
                case 7:
                    VendingMachine amount1 = new VendingMachine();
                    amount1.FindNoOfNotes();
                    break;
                case 8:
                    DayOfWeekCalendar day = new DayOfWeekCalendar();
                    day.DayOfWeek();
                    break;
                case 9:
                    TemperatureConversion temp = new TemperatureConversion();
                    temp.TempConversion();
                    break;
                case 10:
                    MonthlyPayment payment = new MonthlyPayment();
                    payment.Monyhlypayment();
                    break;
                default:
                    Console.WriteLine("\nSelect Option Only From Above List..");
                    break;
            }
            
        }
    }
}
