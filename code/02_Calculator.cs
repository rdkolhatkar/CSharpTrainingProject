using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.code
{
    public class Calculator
    {
        public void calculatorTest()
        {
            Console.WriteLine("Enter your first number : ");
            String numOne = Console.ReadLine();
            Console.WriteLine("You Entered first number as : " + numOne);

            Console.WriteLine("Enter your second number : ");
            String numTwo = Console.ReadLine();
            Console.WriteLine("You Entered second number as : " + numTwo);

            // Converting String to Integer Value
            int firstNumber = int.Parse(numOne);
            int secondNumber = int.Parse(numTwo);

            // Validating positive numbers
            if (firstNumber < 0 || secondNumber < 0)
            {
                Console.WriteLine("Negative numbers are not allowed. Please enter positive numbers only.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Select the operation you want to perform:");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");
            Console.WriteLine("% : Modulus (Remainder)");

            String operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Addition of " + firstNumber + " and " + secondNumber +
                                      " is : " + (firstNumber + secondNumber));
                    break;

                case "-":
                    Console.WriteLine("Subtraction of " + firstNumber + " and " + secondNumber +
                                      " is : " + (firstNumber - secondNumber));
                    break;

                case "*":
                    Console.WriteLine("Multiplication of " + firstNumber + " and " + secondNumber +
                                      " is : " + (firstNumber * secondNumber));
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine("Division of " + firstNumber + " by " + secondNumber +
                                          " is : " + (firstNumber / secondNumber));
                    }
                    break;

                case "%":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Modulus by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine("Remainder when " + firstNumber + " is divided by " +
                                          secondNumber + " is : " + (firstNumber % secondNumber));
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }

            Console.ReadKey();
        }
    }
}