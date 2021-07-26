using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class BinaryNibbleSwap
    {
        List<int> reverseBinary = new List<int>();
        List<int> binary = new List<int>();
        int num;
        public void ToBinary()
        {
            Console.Write("\nEnter the Number Need to Change to Binary Between 0 to 255: ");
            num = Convert.ToInt32(Console.ReadLine());
            int number = num;

            while (number > 0)
            {
                reverseBinary.Add(number % 2);
                number = number / 2;
            }

            for (int i = reverseBinary.Count - 1; i >= 0; i--)
            {
                binary.Add(reverseBinary[i]);
            }
            while (true) // If 8 bits are Not completed, It can add 0 at left
            {
                if (binary.Count != 8)
                    binary.Insert(0, 0);
                else if (binary.Count == 8)
                    break;
            }
        }

        List<int> swap = new List<int>();
        public void NibbleSwap()
        {
            ToBinary();
            
            for (int i = 4; i <= 7; i++) //Swaping 2nd nibble to Left
            {
                swap.Add(binary[i]);
            }
            for (int j = 0; j < 4; j++) //Swaping 1st nibble to Right
            {
                swap.Add(binary[j]);
            }
        }

        int resultant = 0;
        public void NibbleSwapResultant()
        {
            NibbleSwap();
            for (int i = 7, count = 0; i >= 0; i--, count++) //This for loop is for converting the binary numbers after swaping into decimal numbers.
            {
                
                if (swap[i] == 1)
                {
                    resultant += Convert.ToInt32(Math.Pow(2, count));
                }
            }
            Console.WriteLine("\nNibble Swap Resultant Of " + num + " is " + resultant);
        }
    }
}
