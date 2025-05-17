using System;
using System.Collections.Generic;

namespace Homework4
{
    internal class Program
    {
        static void Main()
        {
            AnalyzeTextInput();
        }
        
        static void AnalyzeTextInput()
        {
            Console.Write("Enter text: ");
            string inputText = Console.ReadLine();
            
            if (string.IsNullOrEmpty(inputText))
            {
                Console.WriteLine("Text is empty. Contains 0 characters.");
            }
            else
            {
                Console.WriteLine($"Text \"{inputText}\" contains {inputText.Length} character(s)");
                
                Console.Write("Enter a character to count: ");
                if (char.TryParse(Console.ReadLine(), out char targetChar))
                { 
                    int matchCount = 0;
                    foreach (char ch in inputText)
                    {
                        if (char.ToLower(ch) == char.ToLower(targetChar))
                            matchCount++;
                    }
                    Console.WriteLine($"Character '{targetChar}' found {matchCount} time(s) (case-insensitive).");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a single character.");
                }
            }
        }
    }
}