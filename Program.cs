﻿using System;
using System.Diagnostics;

namespace HelloWorld
{
  class Program
  {
        static void Main(string[] args)
        {
            // Output to console
            Console.WriteLine("Hello World! By Kim Richards"); // New line appended
            Console.Write("Hello! From Kim"); // No new line appended
            Console.WriteLine();

            // Floats
            Console.WriteLine(2.5F); // 6-9 digits
            Console.WriteLine(4.7777); // 15-17 digits, double (default)
            Console.WriteLine(2.4444444444m); //28-29 digits 

            // Boolean 
            Console.WriteLine(true); // = True
            Console.WriteLine(false); // = False

            //// Strings
            // Escape Character: / 
            Console.WriteLine("Hello \tAll"); // Tab
            Console.WriteLine("Hello \n all"); // New line character
            Console.WriteLine("To include a single slash \\");
            Console.WriteLine(@"This is a Verbatim string, you \ can 
                do whatever (almost) you like "); //Verbatim String Literal
            Console.WriteLine("\u306F\u306b"); // Unicode escape characters
            // Concatenation
            string name = "Bob";
            string message = "Hello " + name;
            //Interpolation
            int version = 4;
            string updateMessage = "Update to version";
            string interpolationMessage = $"{updateMessage} {version}";
            Console.WriteLine(interpolationMessage);

            //// Variables
            // You must declare the datatype fist
            string firstName;
            string lastName = "Richards";
            char userOption;
            int score;
            decimal particlesPerMillion;
            bool userAuthenticated;

            // Implicitly typed local variables
            var newMessage = "Hello Kim"; // You can then not convert it implicity to another type and they must be intitialised

            string firstName2 = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName2 + " sold " + (widgetsSold + 7) + " widgets."); // surround the int with brackets if you do't implicitly want it converting to a string

            // Operators
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;
            int remainder = 7 % 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient); // Notice that the / doesn't print the actual value, just the quotient*
            Console.WriteLine("Remainder: " + remainder);

            //* To do actual division, you need to use a datatype that supports fractional digits
            decimal decimalQuotient = 7.0m / 5; // THE LEFT MUST BE DECIMAL decimal decimalQuotient = 7 / 5.0m; wont work
            decimal decimalQuotient2 = 7.0m / 5.0m; // This will work too
            Console.WriteLine($"Decimal Division {decimalQuotient}");
            Console.WriteLine($"Decimal Division {decimalQuotient2}");

            // You could cast ints to decimals
            int first = 7;
            int second = 5;
            decimal quotient3 = (decimal)first / (decimal)second;
            Console.WriteLine(quotient3);

            // Increment/Decrement
            int value = 1;
            value++;
            Console.WriteLine("First: " + value); //2
            Console.WriteLine($"Second: {value++}"); //2
            Console.WriteLine("Third: " + value); //3
            Console.WriteLine("Fourth: " + (++value)); //4

            // Fahrenheit to Celsius
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9); // 5m/9m would also work
            Console.WriteLine("The temperature is " + celsius + " Celsius.");

        }
  }
}