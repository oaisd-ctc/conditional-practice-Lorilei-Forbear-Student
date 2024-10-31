using System;
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value
        CheckForPositiveNegativeZero();
    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero()
    {
        
    }

    }
}
