using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.src
{
    /*
     * Inheritance: Child class inherits members (fields, methods, properties)
     * from Parent class using ':' syntax. Enables code reuse and IS-A relationship.
     * Example: class Dog : Animal { } => Dog inherits Animal. Here Animal is parent and Dog is child class
     */
    public class ImplementInheritance : InheritanceTest
    {
        public void multiplyTwoNumbers()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;

            Console.WriteLine($"Multiplication Result = {result}");
        }
        public static void Run()
        {
            ImplementInheritance implementInheritance = new ImplementInheritance();
            implementInheritance.subtractTwoNumbers(); // This method is present inside the parent class called 'InheritanceTest'
            implementInheritance.multiplyTwoNumbers(); // This method is present inside the child class called 'ImplementInheritance'
        }
    }
}
