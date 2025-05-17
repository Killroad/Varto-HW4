using System;
using System.Collections.Generic;

namespace Homework4
{
    internal class Program
    {
        static void Main()
        {
            DisplayAsciiTable();
        }
        
        static void DisplayAsciiTable()
        {
            char[] charsList = new char[26];
            
            for (int i = 0; i < charsList.Length; i++)
            {
                charsList[i] = (char)('a' + i);
            }

            foreach (char ch in charsList)
            {
                Console.WriteLine($"'{ch}' -> ASCII: {(int)ch}");
            }
        }
    }
}