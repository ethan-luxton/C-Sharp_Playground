using System;

class FibSequence
{
    public static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();
        try
        {
            int result = Int32.Parse(input);
            Console.WriteLine($"Fib sequence result: {fib(result)}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse '{input}'");
        }
    }

    public static int fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return fib(n - 1) + fib(n - 2);
        }
    }
}


