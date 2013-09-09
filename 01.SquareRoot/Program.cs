using System;

class SquareRoot
{
    public static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new System.ArgumentOutOfRangeException(
               "Sqrt for negative numbers is undefined!");
        }
        else
        {
            return Math.Sqrt(value);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number:");
        try
        {
            double n = int.Parse(Console.ReadLine());
            double result = Sqrt(n);
            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Error: Invalid number");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error: Invalid number - " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}