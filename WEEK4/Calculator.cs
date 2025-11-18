namespace WEEK4;

public class Calculator
{
    // Method 1: Prints a welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Method 2: Returns addition of two numbers
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method 3: Returns multiplication, second number optional
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
