using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class DayOfWeekCalendar
    {
        public void DayOfWeek()
        {
            Console.WriteLine("\nGive the Below Details of Date ");
            Console.Write("\nEnter day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int yearOne = year - (14 - month) / 12;
            int x = yearOne + (yearOne / 4) - (yearOne / 100) + (yearOne / 400);
            int monthOne = month + (12 * ((14 - month) / 12)) - 2;
            int dayOne = (day + x + ((31 * monthOne) / 12)) % 7;

            Console.WriteLine("\nDay of Week: " + dayOne);
            
            // I Personally Extended This to Give Perfect Output in Words as Day of Week
            switch (dayOne)
            {
                case 0:
                    Console.WriteLine("\nGiven date is SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("\nGiven date is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("\nGiven date is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("\nGiven date is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("\nGiven date is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("\nGiven date is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("\nGiven date is SATURDAY");
                    break;
            }
        }
    }
}
