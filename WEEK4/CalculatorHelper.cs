namespace WEEK4;

using System;

public static class CalculatorHelper
{
    // Method to safely read integer input using TryParse
    public static bool ReadInteger(string prompt, out int number)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        return int.TryParse(input, out number);
    }

    // Method to calculate percentage
    public static double CalculatePercentage(int marks, int total)
    {
        return (double)marks / total * 100;
    }
}
