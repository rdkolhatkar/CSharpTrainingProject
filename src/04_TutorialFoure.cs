using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.src
{
    public class TestClass
    {
        // in C# there can only be one main entry point or a Main method in entire C# project. Unlike in Java we cannot create different classes which contains the Main method.

        public void addNumbers()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Sum = " + sum);
        }
    }
}
