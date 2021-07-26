using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class OptionSelection
    {
        public void SelectOption()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome To Logical Programming in C#.. ");
                Console.WriteLine("\n1. Fibonacci Series" +
                    "\n2. Perfect Number" +
                    "\n3. Prime Number" +
                    "\n4. Reverse a Number" +
                    "\n5. Coupon Numbers" +
                    "\n6. StopWatch Simulation" +
                    "\n7. Vending Machine" +
                    "\n8. Day Of Week (Calendar Problem)" +
                    "\n9. Temperatur Conversion" +
                    "\n10. Monthly Payment" +
                    "\n11. SquareRoot Using Newton Method" +
                    "\n12. To Binary" +
                    "\n13. Nibble Swap Number" +
                    "\n\nType ' End ' To Exit Programming");
                Console.Write("\nPlease Select One Option From Above: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        FibonacciSeries fibonacci = new FibonacciSeries();
                        fibonacci.Fibonacci();
                        break;
                    case "2":
                        PerfectNumber number = new PerfectNumber();
                        number.PerfectNumberCheck();
                        break;
                    case "3":
                        PrimeNumber number1 = new PrimeNumber();
                        number1.PrimeNumberCheck();
                        break;
                    case "4":
                        ReverseNum number2 = new ReverseNum();
                        number2.Reverse();
                        break;
                    case "5":
                        CouponNumber number3 = new CouponNumber();
                        number3.CouponGenerator();
                        break;
                    case "6":
                        StopWatch time = new StopWatch();
                        time.ElapsedTime();
                        break;
                    case "7":
                        VendingMachine amount1 = new VendingMachine();
                        amount1.FindNoOfNotes();
                        break;
                    case "8":
                        DayOfWeekCalendar day = new DayOfWeekCalendar();
                        day.DayOfWeek();
                        break;
                    case "9":
                        TemperatureConversion temp = new TemperatureConversion();
                        temp.TempConversion();
                        break;
                    case "10":
                        MonthlyPayment payment = new MonthlyPayment();
                        payment.Monyhlypayment();
                        break;
                    case "11":
                        SquareRoot number4 = new SquareRoot();
                        number4.SqRtNewton();
                        break;
                    case "12":
                        Binary binary = new Binary();
                        binary.BinaryRepresentation();
                        break;
                    case "13":
                        BinaryNibbleSwap swap = new BinaryNibbleSwap();
                        swap.NibbleSwapResultant();
                        break;
                    case "End":
                        Console.WriteLine("\nThankyou..");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Option - If You Want To exit Type ' End '");
                        break;
                }
                if (option == "End")
                    break;
            }
        }
    }
}
