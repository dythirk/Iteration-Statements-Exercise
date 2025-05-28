using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {    
            PrintNumbers();
            PrintEveryThirdNumber();

            int first, second;

            // Comparison
            Console.WriteLine("Please enter first number: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Are the numbers equal? {AreNumbersEqual(first, second)}\n");

            // Checking Even
            Console.WriteLine("Please enter a number (checking Even): ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is the number even? {IsEven(first)}\n");

            // Checking Positive
            first = 0;
            while (first == 0)
            {
                Console.WriteLine("Please enter a number (checking Positive): ");
                first = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Is the number positive? {IsPositive(first)}\n");

            // Checking eligibilty to vote
            Console.WriteLine($"Is the candidate eligible to vote? {CanVote()}\n");

            // Checking range -10 to 10
            Console.WriteLine("Please enter a number (range -10 to 10): ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is the number in range? {IsInRange(first)}\n");

            // Multiplication
            Console.WriteLine("Please enter a number (multiplication): ");
            first = Convert.ToInt32(Console.ReadLine());
            DisplayMultiplicationTable(first);


        }
        static void PrintNumbers()
        {
            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine($"{i}\n");
            }
        }
        static void PrintEveryThirdNumber()
        {
            for (int i = 3; i < 1000; i = i + 3)
            {
                Console.WriteLine($"{i}\n");
            }
        }
        static bool AreNumbersEqual(int first, int second)
        {
            return first == second;
        }
        static bool IsEven(int number)            
        {
            return (number % 2 == 0);
        }
        static bool IsPositive(int number)
        {
            return (number > 0);
        }
        static bool CanVote()
        {
            {
                Console.WriteLine("Please enter the candidate's age (checking Eligibility): ");
                var canParse = int.TryParse(Console.ReadLine(), out int age);
                while (canParse == false)
                {
                    Console.WriteLine("Please enter a valid age: ");
                    canParse = int.TryParse(Console.ReadLine(), out age);

                }
                return (age >= 18);
            }
        }
        static bool IsInRange(int number)
        {
            return ((number >= -10) && (number <= 10));
        }
        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 0; i < 12; i++)
                Console.WriteLine($"{i+1} * {number} = {(i + 1) * number}");
        }
    }
}
