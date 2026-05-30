using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.src
{
    public class InheritanceTest
    {
        public void subtractTwoNumbers()
        {
            // Display a message to the user without moving to the next line.
            Console.Write("Enter first number: ");

            /*
             * Console.ReadLine()
             * ------------------
             * Reads input from the keyboard and returns it as a string.
             *
             * Example:
             * User enters: 100
             * Returns: "100"
             */

            /*
             * int.TryParse()
             * --------------
             * Safely converts a string into an integer.
             *
             * Syntax:
             * int.TryParse(stringValue, out int result)
             *
             * Returns:
             * - true  -> if conversion succeeds
             * - false -> if conversion fails
             *
             * Example:
             * int.TryParse("123", out int x) -> true, x = 123
             * int.TryParse("abc", out int x) -> false, x = 0
             *
             * Why use TryParse?
             * -----------------
             * Unlike int.Parse(), it does NOT throw an exception
             * when the user enters invalid data.
             */

            bool isNum1Valid = int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Enter second number: ");

            bool isNum2Valid = int.TryParse(Console.ReadLine(), out int num2);

            /*
             * Logical AND (&&)
             * ----------------
             * Both conditions must be true.
             *
             * If either input is invalid,
             * the else block will execute.
             */
            if (isNum1Valid && isNum2Valid)
            {
                // Subtract second number from first number
                int result = num1 - num2;

                /*
                 * String Interpolation
                 * --------------------
                 * $"" allows embedding variables directly in strings.
                 *
                 * Example:
                 * $"Result = {result}"
                 *
                 * If result = 10
                 * Output: Result = 10
                 */
                Console.WriteLine($"Result = {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
    }
}
