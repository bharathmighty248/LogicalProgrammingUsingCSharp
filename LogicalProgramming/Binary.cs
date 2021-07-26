using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class Binary
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

        public void BinaryRepresentation()
        {
            ToBinary();
            Console.Write("\nBinary Representation of " + num + " is ");
            for (int i = 0; i <= binary.Count - 1; i++)
            {
                int binaryRepresent = binary[i];
              Console.Write(binaryRepresent);
            }
            Console.WriteLine();
        }
    }
}