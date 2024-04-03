using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Greetings object
        Greetings greetings = new Greetings();

        // Call the Welcome function from Greetings.cs
        greetings.Welcome();

        // Call the Hello method with a string argument
        greetings.Hello("John");
    }
}