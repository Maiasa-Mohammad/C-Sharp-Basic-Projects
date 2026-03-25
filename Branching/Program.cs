using System;

class Program
{
    static void Main()
    {
        // Display the initial greeting message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the package weight
        Console.WriteLine("Please enter the package weight:");
        float weight = float.Parse(Console.ReadLine()); // Convert user input to a number

        // Check if the package is too heavy
        if (weight > 50)
        {
            // Display error and end program if weight exceeds limit
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Prompt the user to enter the package width
        Console.WriteLine("Please enter the package width:");
        float width = float.Parse(Console.ReadLine());

        // Prompt the user to enter the package height
        Console.WriteLine("Please enter the package height:");
        float height = float.Parse(Console.ReadLine());

        // Prompt the user to enter the package length
        Console.WriteLine("Please enter the package length:");
        float length = float.Parse(Console.ReadLine());

        // Check if the total dimensions exceed the allowed limit
        if (width + height + length > 50)
        {
            // Display error and end program if dimensions exceed limit
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the shipping quote:
        // Multiply width × height × length × weight, then divide by 100
        float quote = (width * height * length * weight) / 100;

        // Display the final quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
