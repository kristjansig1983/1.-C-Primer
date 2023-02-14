using System;
using System.Collections.Generic;

class NumberList
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (or press enter to stop): ");
            string input = Console.ReadLine();

            if (input == "")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("You didn't enter any numbers.");
            Console.ReadLine();
            return;
        }

        int largest = numbers[0];
        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }

            if (number < smallest)
            {
                smallest = number;
            }
        }

        Console.WriteLine($"The largest number you entered is {largest}.");
        Console.WriteLine($"The smallest number you entered is {smallest}.");
        Console.ReadLine();
    }
}