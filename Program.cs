using System;
public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(100);
        CheckForPositiveNegativeZero(26); 
        FindMinimum(9, -3, 40);
        FindMaximum(2, 56, 32);
        //IsDivisibleBy5(30);
        //CheckEvenOrOdd(73);
        CheckVowelOrConsonant('h');
        DisplayDayOfWeek(4);
    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int positivenegativezero)
    {
        if (positivenegativezero > 0)
        {
        Console.WriteLine($"{positivenegativezero} is a positive number.");
        }

        else if (positivenegativezero < 0)
        {
            Console.WriteLine($"{positivenegativezero} is a negative number.");
        }
        else
        {
            Console.WriteLine($"You input zero.");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 <= num2 && num1 <= num3)
        {
            Console.WriteLine($"{num1} is the smallest number.");
        }
        else if(num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine($"{num2} is the smallest number.");
        }
        else
        {
            Console.WriteLine($"{num3} is the smallest number.");
        }
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine($"{num1} is the greatest number.");
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine($"{num2} is the greatest number.");
        }
        else
        {
            Console.WriteLine($"{num3} is the greatest number.");
        }
    }

    public static void IsDivisibleBy5(int number) //not done
    {
        
    }

    public static void CheckEvenOrOdd(int number) //not done
    {
        //figure out later
    }

    public static void CheckVowelOrConsonant(char letter)
    {
        switch(letter)
        {
            case 'E':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'e':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'A':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'a':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'I':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'i':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'O':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'o':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'U':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'u':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'Y':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            case 'y':
                Console.WriteLine($"{letter} is a vowel.");
                break;
            default: 
                Console.WriteLine($"{letter} is a consonant.");
                break;
        }
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        switch (dayCode)
        {
            case 0:
                Console.WriteLine("It is Sunday.");
                break;
            case 1:
                Console.WriteLine("It is Monday.");
                break;
            case 2:
                Console.WriteLine("It is Tuesday.");
                break;
            case 3:
                Console.WriteLine("It is Wednesday.");
                break;
            case 4:
                Console.WriteLine("It is Thursday.");
                break;
            case 5: 
                Console.WriteLine("It is Friday.");
                break;
            case 6:
                Console.WriteLine("It is Saturday.");
                break;
            default:
                Console.WriteLine("This number does not correspond to a dayCode.");
                break;
        }
    }


}

