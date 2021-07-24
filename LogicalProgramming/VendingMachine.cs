using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class VendingMachine
    {
        public void FindNoOfNotes()
        {
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notesAvailable = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notesCounter = new int[notesAvailable.Length];
            for (int i = 0; i < notesAvailable.Length; i++)
            {
                if (amount >= notesAvailable[i])
                {
                    notesCounter[i] = amount / notesAvailable[i];
                    amount -= (notesAvailable[i] * notesCounter[i]);
                    if (amount <= 0)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < notesCounter.Length; i++)
            {
                if (notesCounter[i] != 0)
                {
                    Console.WriteLine("\n" + notesCounter[i] + " Notes of Rs." + notesAvailable[i] + " is Required..");
                }
            }

        }
    }
}
