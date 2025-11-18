using System;
namespace WEEK4;
class Program
{
    static void Main(string[] args)
    {
        // Creating first student object
        Student s1 = new Student();
        s1.name = "Roshan";
        s1.age = 20;
        s1.address = "Kathmandu";

        // Creating second student object
        Student s2 = new Student();
        s2.name = "Aayush";
        s2.age = 22;
        s2.address = "Pokhara";

        // Displaying details of first student
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine(s1.name);
        Console.WriteLine($"Age: {s1.age}");
        Console.WriteLine($"Address: {s1.address}");

        Console.WriteLine();

        // Displaying details of second student
        Console.WriteLine("Student 2 Details:");
        Console.WriteLine($"Name: {s2.name}");
        Console.WriteLine($"Age: {s2.age}");
        Console.WriteLine($"Address: {s2.address}");

        Console.WriteLine();

        // Printing static field
        Console.WriteLine($"School Name (Static Field): {Student.schoolName}");
        
        
            // Creating object of Calculator
            Calculator calc = new Calculator();

            // Calling welcome method
            calc.PrintWelcome();

            // Calling Add method
            int sum = calc.Add(5, 10);

            // Calling Multiply method (with and without optional parameter)
            int product1 = calc.Multiply(4, 3); // uses both numbers
            int product2 = calc.Multiply(7);    // uses default value for num2 (1)

            // Printing results
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product (4 * 3): {product1}");
            Console.WriteLine($"Product with default value (7 * 1): {product2}");
            
            ParameterDemo demo = new ParameterDemo();

            // Using ref
            int num = 5;
            demo.Increase(ref num);
            Console.WriteLine($"Number after Increase: {num}");

            // Using out
            demo.GetFullName(out string fullName);
            Console.WriteLine($"Full Name: {fullName}");

            // Using params
            int Total = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of all numbers: {Total}");
            // Creating object using default constructor
            Player p1 = new Player();

            // Setting fields manually for p1
            p1.playerName = "Unknown";
            p1.level = 0;
            p1.health = 0;

            // Creating object using parameterized constructor
            Player p2 = new Player("Roshan", 5, 100);

            // Printing details of first player
            Console.WriteLine("\nPlayer 1 Details:");
            Console.WriteLine($"Name: {p1.playerName}, Level: {p1.level}, Health: {p1.health}");

            // Printing details of second player
            Console.WriteLine("\nPlayer 2 Details:");
            Console.WriteLine($"Name: {p2.playerName}, Level: {p2.level}, Health: {p2.health}");
            // ----------- DayType Example -----------
            Console.Write("Enter a day: ");
            string day = Console.ReadLine()?.Trim();

            DayType dayType;

            if (day == "Friday" || day == "Saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine($"It is: {dayType}");

            Console.WriteLine("\n--------------------\n");

            // ----------- Book Record Example -----------
            // Creating first book object
            Book book1 = new Book("C# Programming", "John Doe", 29.99);

            // Creating second book object with 'with' expression
            Book book2 = book1 with { title = "Advanced C#", price = 39.99 };

            // Printing first book
            Console.WriteLine("First Book:");
            Console.WriteLine(book1);

            // Deconstructing second book
            var (title, author, price) = book2;
            Console.WriteLine("\nSecond Book Deconstructed:");
            Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");
            // Read marks
            if (!CalculatorHelper.ReadInteger("Enter obtained marks: ", out int marks))
            {
                Console.WriteLine("Invalid input for marks.");
                return;
            }

            // Read total marks
            if (!CalculatorHelper.ReadInteger("Enter total marks: ", out int total) || total == 0)
            {
                Console.WriteLine("Invalid input for total marks or total is zero.");
                return;
            }

            // ---------------- Breakpoint 1 ----------------
            double percentage = CalculatorHelper.CalculatePercentage(marks, total);
            // ---------------- Breakpoint 2 ----------------

            Console.WriteLine($"Percentage: {percentage}%");
    }
    
    
    enum DayType
    {
        Weekday,
        Weekend
    }

// Record for Book
    record Book(string title, string author, double price);

}