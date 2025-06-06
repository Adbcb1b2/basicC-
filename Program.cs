﻿using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

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

// // Uncomment for else if statement example
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Random dice = new Random();

//             int roll1 = dice.Next(1, 7);
//             int roll2 = dice.Next(1, 7);
//             int roll3 = dice.Next(1, 7);

//             int total = roll1 + roll2 + roll3;

//             Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//             if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//             {
//                 if ((roll1 == roll2) && (roll2 == roll3))
//                 {
//                     Console.WriteLine("You rolled triples!  +6 bonus to total!");
//                     total += 6;
//                 }
//                 else
//                 {
//                     Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//                     total += 2;
//                 }

//                 Console.WriteLine($"Your total including the bonus: {total}");
//             }

//             if (total >= 16)
//             {
//                 Console.WriteLine("You won a car!");
//             }
//             else if (total >= 10)
//             {
//                 Console.WriteLine("You won a holiday");
//             }
//             else if (total >= 5)
//             {
//                 Console.WriteLine("You won a bike!");
//             }
//             else
//             {
//                 Console.WriteLine("You won £5");
//             }
//         }
//     }
// }

// // Coding Challenge - Improve renewal rate of subsciptions. 
// // Display a renewal message when a user logs into the software system and is notified their subscription will soon end
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Create an instance of the random class 
//             Random random = new();

//             // Create a random number for days until subscription ends 0 - 11
//             //int daysUntilExpiration = random.Next(1, 11);
//             int daysUntilExpiration = 4;

//             // Create a variable to hold the discount percentage, default 0
//             int discountPercentage = 0;


//             // Display one message dependent on one of the 5 rules. 
//             // Rule 1: For rules 2-6, the higher numbered rules take precedence over the lower numbered rules 
//             // Rule 2: If the user's subscription will expire in 10 days or less, display the message "Your subscription will expire soon. Renew now!"
//             // Rule 3: If the user's subscription will expire in five days or less, display the messages "Your subscription expires in _ days. \n Renew now and save 10%!"
//             // Rule 4: If the user's subscription will expire in one day, display "Your subscription expires within a day! Renew now and save 20%!"
//             // Rule 5: If the user's subscription has expired, display the message "Your subscription has expired."
//             // Rule 6: If the user's subscription doesn't expire within 10 days, display nothing. 

//             // Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!");

//             if (daysUntilExpiration <= 10) // Rule 6
//             {
//                 // Implement logic
//                 if (daysUntilExpiration <= 0)
//                 {
//                     Console.WriteLine("Your subscription has expired!"); // Rule 5
//                 }
//                 else if (daysUntilExpiration == 1)
//                 {
//                     discountPercentage = 20;
//                     Console.WriteLine($"Your subscription expires within a day!"); // Rule 4        
//                 }
//                 else if (daysUntilExpiration <= 5)
//                 {
//                     discountPercentage = 10;
//                     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!"); // Rule 3

//                 }
//                 else
//                 {
//                     Console.WriteLine("Your subscription will expire soon! Renew now!"); // Rule 2
//                 }
//             }

//             if (discountPercentage > 0)
//             {
//                 Console.WriteLine($"Renew now and save {discountPercentage}%!");
//             }
//         }
//     }
// }

// // Uncomment for array examples
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             // To declare an array, you must declare the type and the size 
//             string[] fraudulentOrderIDs = new string[3];

//             // Assigning values to an array
//             fraudulentOrderIDs[0] = "A665";  // First element is 0
//             fraudulentOrderIDs[1] = "B432";
//             fraudulentOrderIDs[2] = "J451";

//             // Could also do the above like this string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

//             // Retrieving values from elements in an array
//             string[] orderIDs = new string[3];
//             orderIDs[0] = "124C";
//             orderIDs[1] = "224B";
//             orderIDs[2] = "154F";

//             // Accessing the first element of the array
//             Console.WriteLine($"First element of the array: {orderIDs[0]}");

//             // Accessing the last element of the array
//             Console.WriteLine($"Last element of the array: {orderIDs[2]}");

//             // Reassingning the value of an array
//             orderIDs[0] = "F000";
//             Console.WriteLine($"Reassigned First Element = {orderIDs[0]}");

//             // The length property of an array
//             Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders");

//             // Looping through an array
//             string[] names = ["Kim", "Bob", "Brian"];
//             foreach (string name in names)
//             {
//                 Console.WriteLine(name); // Will iterate through each element of the array and print the line
//             }

//             // You can have different types of an array:
//             int[] pictureUnitsRemainingPerType = [500, 20, 30, 1, 12];
//             int sum = 0; // Initialise sum variable

//             // Calculate the total number of units
//             foreach (int pictureType in pictureUnitsRemainingPerType)
//             {
//                 sum += pictureType;

//             }

//             // Output the total   
//             Console.WriteLine("Total amount of units: " + sum);

//             // Creating a variable to hold the current iteration
//             int[] inventory = [200, 250, 700, 175, 250];
//             int total = 0;
//             int bin = 0;

//             foreach (int items in inventory)
//             {
//                 total += items;
//                 bin++;
//                 Console.WriteLine($"Bin Number (iteration number) {bin} has {items}. The running total is {total} items");
//             }

//         }
//     }
// }

// // Uncomment for Fraudulent Order Challenge
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
//             int iterationID = 0;

//             foreach (string fraudulentOrderID in fraudulentOrderIDs)
//             {
//                 if (fraudulentOrderID.StartsWith("B"))
//                 {
//                     Console.WriteLine($"The order at position {iterationID} is fradulent: {fraudulentOrderID}");
//                 }
//                 iterationID++;
//             }
//         }
//     }
// }

// Uncomment for foreach and if-elseif-else example
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAssignmentCount = 5;

            int[] sophiaGrades = [90, 86, 87, 98, 100, 94, 90];
            int[] kimGrades = [92, 89, 81, 96, 90, 89];
            int[] jamesGrades = [90, 85, 87, 98, 68, 89, 89, 89];
            int[] pippaGrades = [90, 95, 87, 88, 96, 96];

            string[] studentNames = ["Sophia", "Kim", "James", "Pippa"];

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            // Report Header
            Console.WriteLine("Student\t\tGrade\t\tFinal Score\tGrade\t\tExtra Credit\n");

            // Iterate through the student names array
            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                {
                    studentScores = sophiaGrades;
                }
                else if (currentStudent == "Kim")
                {
                    studentScores = kimGrades;
                }
                else if (currentStudent == "James")
                {
                    studentScores = jamesGrades;
                }
                else if (currentStudent == "Pippa")
                {
                    studentScores = pippaGrades;
                }
                
                // Initialise/reset the sum of the scores
                int sumAssignmentScore = 0;
                int sumExtraAssignmentScore = 0;

                // Initialise/reset the calculated average of exam + extra credit scores
                decimal currentStudentGrade = 0;
                decimal extraCreditPoints = 0;

                // To keep track of which element of the array is being processed
                int arrayElementID = 0;

                // To keep track of how many extra credit values there are
                int extraCreditValues = 0;
                
                // Iterate through current student's grades to calculate the sum
                foreach (int grade in studentScores)
                {
                    // Test - Console.WriteLine(grade + " ");

                    arrayElementID += 1;

                    if (arrayElementID <= currentAssignmentCount)
                    {
                        sumAssignmentScore += grade;
                    }
                    else
                    {
                        sumExtraAssignmentScore += grade;
                        extraCreditValues++;
                    }
                }

                // Calculate the average of the student's scores - without accounting for extra credits
                currentStudentGrade = (decimal)sumAssignmentScore / currentAssignmentCount;

                // Calculate extra credit points earned as 10% of extra credit score
                extraCreditPoints = (decimal)sumExtraAssignmentScore / 10;

                //Add extra credit points to the sum of regular exam scores
                decimal finalScore = (decimal)(sumAssignmentScore + extraCreditPoints) / currentAssignmentCount;


                if (finalScore >= 97)
                    currentStudentLetterGrade = "A+";

                else if (finalScore >= 93)
                    currentStudentLetterGrade = "A";

                else if (finalScore >= 90)
                    currentStudentLetterGrade = "A-";

                else if (finalScore >= 87)
                    currentStudentLetterGrade = "B+";

                else if (finalScore >= 83)
                    currentStudentLetterGrade = "B";

                else if (finalScore >= 80)
                    currentStudentLetterGrade = "B-";

                else if (finalScore >= 77)
                    currentStudentLetterGrade = "C+";

                else if (finalScore >= 73)
                    currentStudentLetterGrade = "C";

                else if (finalScore >= 70)
                    currentStudentLetterGrade = "C-";

                else if (finalScore >= 67)
                    currentStudentLetterGrade = "D+";

                else if (finalScore >= 63)
                    currentStudentLetterGrade = "D";

                else if (finalScore >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($"{name}\t\t{sumAssignmentScore / (decimal)currentAssignmentCount}\t\t{finalScore:F2}\t\t{currentStudentLetterGrade}\t\t{sumExtraAssignmentScore/extraCreditValues} pts ({(decimal)(sumExtraAssignmentScore*0.1)/currentAssignmentCount})");

            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();

        }
    }
}