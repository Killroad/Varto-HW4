using System;
using System.Collections.Generic;

namespace Homework4
{
    internal class Program
    {
        static void Main()
        {
            GenerateEvenNumbersArray();
        }
        
        static void GenerateEvenNumbersArray()
        {
            int[] evenNumbers = new int[50];
            
            for (int i = 0, j = 2; i < evenNumbers.Length; i++, j += 2)
            {
                evenNumbers[i] = j;
            }

            foreach (int number in evenNumbers)
            {
                Console.WriteLine($"Number: {number}");
            }
        }
    }
}