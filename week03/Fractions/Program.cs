using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();        // 1/1
        Fraction fraction2 = new Fraction(5);       // 5/1
        Fraction fraction3 = new Fraction(3, 4);    // 3/4
        Fraction fraction4 = new Fraction(1, 3);    // 1/3

        Console.WriteLine("Testing getters and setters:");
        fraction1.SetTop(2);
        fraction1.SetBottom(3);
        Console.WriteLine($"Top: {fraction1.GetTop()}, Bottom: {fraction1.GetBottom()}");

        Console.WriteLine("\nFraction representations:");
        
        // Fraction 1
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetDecimalValue()}");

        // Fraction 2
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");

        // Fraction 3
        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");

        // Fraction 4
        Console.WriteLine($"{fraction4.GetFractionString()}");
        Console.WriteLine($"{fraction4.GetDecimalValue()}");

        Console.WriteLine("\nAdditional test cases:");
        Fraction fraction5 = new Fraction(); // 1/1
        Console.WriteLine($"{fraction5.GetFractionString()}");
        Console.WriteLine($"{fraction5.GetDecimalValue()}");

        Fraction fraction6 = new Fraction(6); // 6/1
        Console.WriteLine($"{fraction6.GetFractionString()}");
        Console.WriteLine($"{fraction6.GetDecimalValue()}");

        Fraction fraction7 = new Fraction(6, 7); // 6/7
        Console.WriteLine($"{fraction7.GetFractionString()}");
        Console.WriteLine($"{fraction7.GetDecimalValue()}");
    }
}