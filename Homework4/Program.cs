using System;
using System.Collections.Generic;

namespace Homework4
{
    internal class Program
    {
        static void Main()
        {
            CountEvenRandomNumbers();
        }
        
        static void CountEvenRandomNumbers()
        {
            int[] numbers = new int[40];
            List<int> evenNumbers = new List<int>();
            Random rng = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 500);
                if (numbers[i] % 2 == 0) 
                    evenNumbers.Add(numbers[i]);
            }
            Console.WriteLine($"Array contains {evenNumbers.Count} even number(s).");
            Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}.");
        }
    }
}