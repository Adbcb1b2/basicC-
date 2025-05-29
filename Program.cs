using System;

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








    }
  }
}