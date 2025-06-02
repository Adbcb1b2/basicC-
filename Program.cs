using System;
using System.Diagnostics;

// Uncomment for simple C# Syntax
// namespace HelloWorld
// {
//   class Program
//   {
//         static void Main(string[] args)
//         {
//             // Output to console
//             Console.WriteLine("Hello World! By Kim Richards"); // New line appended
//             Console.Write("Hello! From Kim"); // No new line appended
//             Console.WriteLine();

//             // Floats
//             Console.WriteLine(2.5F); // 6-9 digits
//             Console.WriteLine(4.7777); // 15-17 digits, double (default)
//             Console.WriteLine(2.4444444444m); //28-29 digits

//             // Boolean
//             Console.WriteLine(true); // = True
//             Console.WriteLine(false); // = False

//             //// Strings
//             // Escape Character: /
//             Console.WriteLine("Hello \tAll"); // Tab
//             Console.WriteLine("Hello \n all"); // New line character
//             Console.WriteLine("To include a single slash \\");
//             Console.WriteLine(@"This is a Verbatim string, you \ can
//                 do whatever (almost) you like "); //Verbatim String Literal
//             Console.WriteLine("\u306F\u306b"); // Unicode escape characters
//             // Concatenation
//             string name = "Bob";
//             string message = "Hello " + name;
//             //Interpolation
//             int version = 4;
//             string updateMessage = "Update to version";
//             string interpolationMessage = $"{updateMessage} {version}";
//             Console.WriteLine(interpolationMessage);

//             //// Variables
//             // You must declare the datatype fist
//             string firstName;
//             string lastName = "Richards";
//             char userOption;
//             int score;
//             decimal particlesPerMillion;
//             bool userAuthenticated;

//             // Implicitly typed local variables
//             var newMessage = "Hello Kim"; // You can then not convert it implicity to another type and they must be intitialised

//             string firstName2 = "Bob";
//             int widgetsSold = 7;
//             Console.WriteLine(firstName2 + " sold " + (widgetsSold + 7) + " widgets."); // surround the int with brackets if you do't implicitly want it converting to a string

//             // Operators
//             int sum = 7 + 5;
//             int difference = 7 - 5;
//             int product = 7 * 5;
//             int quotient = 7 / 5;
//             int remainder = 7 % 5;

//             Console.WriteLine("Sum: " + sum);
//             Console.WriteLine("Difference: " + difference);
//             Console.WriteLine("Product: " + product);
//             Console.WriteLine("Quotient: " + quotient); // Notice that the / doesn't print the actual value, just the quotient*
//             Console.WriteLine("Remainder: " + remainder);

//             //* To do actual division, you need to use a datatype that supports fractional digits
//             decimal decimalQuotient = 7.0m / 5; // THE LEFT MUST BE DECIMAL decimal decimalQuotient = 7 / 5.0m; wont work
//             decimal decimalQuotient2 = 7.0m / 5.0m; // This will work too
//             Console.WriteLine($"Decimal Division {decimalQuotient}");
//             Console.WriteLine($"Decimal Division {decimalQuotient2}");

//             // You could cast ints to decimals
//             int first = 7;
//             int second = 5;
//             decimal quotient3 = (decimal)first / (decimal)second;
//             Console.WriteLine(quotient3);

//             // Increment/Decrement
//             int value = 1;
//             value++;
//             Console.WriteLine("First: " + value); //2
//             Console.WriteLine($"Second: {value++}"); //2
//             Console.WriteLine("Third: " + value); //3
//             Console.WriteLine("Fourth: " + (++value)); //4

//             // Fahrenheit to Celsius
//             int fahrenheit = 94;
//             decimal celsius = (fahrenheit - 32m) * (5m / 9); // 5m/9m would also work
//             Console.WriteLine("The temperature is " + celsius + " Celsius.");

//         }
//   }
// }

// // Uncomment for a demonstration of a stateful method
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Random dice = new Random(); // Create an instance of the random class
//             Random dice = new(); // Latest version of .NET runtime allows you to not repeat the class name, simplifies readability
//             // Random class captures the date/time down to a fraction of a millisecond, and uses it to seed an alogirthm that produces a different number each time.
//             int roll = dice.Next(1, 7); // Random dice roll, 1-7
//             Console.WriteLine("You rolled a: " + roll); // Output dice roll

//             // int result = Random.Next(); // Next() is a stateless object, so it won't allow you to use it wihthout an object
//             roll = dice.Next(); // A stateful method does not necessarily need a parameter
//             Console.WriteLine("Your new random number is: " + roll);
//         }
//     }
// }

// Uncomment for demonstration of parameters/arguments and return values
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random dice = new();
//             int roll = dice.Next(1, 6); // Return a value in a variable
//             Console.WriteLine("" + roll); // Print the return value

//             Console.WriteLine(dice.Next(7, 10));

//         }


//     }
// }

// Uncomment for Math class implementation
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int firstValue = 800;
//             int secondValue = 1000;

//             int largerValue;

//             // Use Max Method of the System.Math class to determine the higher value
//             largerValue = System.Math.Max(firstValue, secondValue);

//             // Print the larger value. Output should be 1000;
//             Console.WriteLine("The larger value is:" + largerValue);
//             Console.WriteLine($"Larger Value {largerValue}");

//         }
//     }
// }

// // Uncomment for if statement examples
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random dice = new();

//             // Generate 3 random numbers
//             int roll1 = dice.Next(1, 7);
//             int roll2 = dice.Next(1, 7);
//             int roll3 = dice.Next(1, 7);

//             // Sum the generated random numbers
//             int total = roll1 + roll2 + roll3;

//             // Output the random numbers and the sum
//             Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

//             // Get 2 extra points if 2 of your dice rolls are equal
//             if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
//             {
//                 Console.WriteLine("You rolled doubles!!!");
//                 total += 2;
//             }

//             // Get 6 extra points if all 3 of your dice rolls are equal
//             if ((roll1 == roll2) && (roll2 == roll3))
//             {
//                 Console.WriteLine("You rolled tripples!");
//                 total += 3;
//             }

//             // Create a win/lose feature depending on the random numbers generated
//             if (total > 14)
//             {
//                 Console.WriteLine("You win!");
//             }


//             string message = "I went to the shop earlier"; // Define a message
//             bool result = message.Contains("dog"); // False. Boolean expressions can also be created using operator e.g. ==, >, <, >=, <= etc.
//             Console.WriteLine("" + result);

//             // Using a boolean expression in an if statement
//             if (message.Contains("shop"))
//             {
//                 Console.WriteLine("The message contains the word shop!");
//             }

//         }
//     }
// }

// // Uncomment for IF/ELSE statement examples
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an instance of the Random class
//             Random dice = new();

//             // Generate 3 random dice rolls
//             int roll1 = dice.Next(1, 7);
//             int roll2 = dice.Next(1, 7);
//             int roll3 = dice.Next(1, 7);

//             // Total the three randomly generated numbers
//             int total = roll1 + roll2 + roll3;

//             // Output the random numbers and the total
//             Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total}");

//             // Bonus points for doubles/triples
//             if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//             {
//                 Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//                 total += 2;
//             }

//             if ((roll1 == roll2) && (roll2 == roll3))
//             {
//                 Console.WriteLine("You rolled triples!  +6 bonus to total!");
//                 total += 6;
//             }


//             // IF/Else statement example
//             if (total >= 15)
//             {
//                 Console.WriteLine("You win!");
//             }
//             else
//             {
//                 Console.WriteLine("Sorry, you lose");
//             }

//         }
//     }
// }

// // Uncomment for nested if/else example
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random dice = new();

//             // Generate three random numbers
//             int roll1 = dice.Next(1, 7);
//             int roll2 = dice.Next(1, 7);
//             int roll3 = dice.Next(1, 7);

//             // Total the three generated random numbers
//             int total = roll1 + roll2 + roll3;

//             // Output the 3 random numbers and their total
//             Console.WriteLine($"{roll1} + {roll2} + {roll3}");

//             // Nested IF/ELSE statement
//             // If doubles are rolled, there's possiblity tripes may have been to
//             if ((roll1 == roll2) || (roll1 == roll3) || roll2 == roll3)
//             {
//                 // Check if triples have also been rolled
//                 if ((roll1 == roll2) && (roll2 == roll3))
//                 {
//                     Console.WriteLine("You rolled tripples!");
//                 }
//                 else // If they havent, doubles have been rolled
//                 {
//                     Console.WriteLine("You've rolled doubles!");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("You didn't roll doubles or triples - no bonus points for you!");
//             }

//             if (total >= 15)
//             {
//                 Console.WriteLine("You win!!");
//             }
//             else
//             {
//                 Console.WriteLine("You lose!!");
//             }

            
//         }
//     }
// }
