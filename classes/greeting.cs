using System;

public class Greetings
{
    // Public function to print a welcome message
    public void Welcome()
    {
        Console.WriteLine("Welcome! We're glad you're here.");
    }

    // Public method that takes a string parameter and prints a personalized message
    public void Hello(string name)
    {
        Console.WriteLine($"{name}, thank you for joining us today!");
    }
}
