using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.src
{
   public class ConstructorTest
    {
        // A Constructor is a method which is called by default when class is initialized.
        // A constructor is a special method that is automatically called when an object is created to initialize the object's state.

        /*
         * A constructor has:
           -> The same name as the class
           -> No return type (not even void)
         * Types Of Constructors in C#
            ------------------------------------------------------------------------
            | Java                                     | C#                        |
            | ---------------------------------------- | ------------------------- |
            | Default Constructor                      | Default Constructor       |
            | Parameterized Constructor                | Parameterized Constructor |
            | Constructor Overloading                  | Constructor Overloading   |
            | Copy Constructor (manual implementation) | Copy Constructor          |
            | Static Block                             | Static Constructor        |
            ------------------------------------------------------------------------
         */

        // Instance Variable
        private string name;
        private int age;

        // Static Variable
        private static string companyName;

        // Static Constructor
        // Called only once when the class is loaded.
        // Used to initialize static members.
        static ConstructorTest()
        {
            companyName = "Microsoft";
            Console.WriteLine("Static Constructor Called");
        }

        // Default Constructor
        // Constructor with no parameters.
        // Used to initialize default values.
        public ConstructorTest()
        {
            Console.WriteLine("Default Constructor Called");
        }

        // Parameterized Constructor
        // this.name refers to instance variable.
        // name refers to constructor parameter.
        public ConstructorTest(string name)
        {
            this.name = name;

            Console.WriteLine($"Parameterized Constructor Called: {this.name}");
        }

        // Constructor Overloading
        // Same constructor name but different parameter list.
        public ConstructorTest(string name, int age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        // Copy Constructor
        // Creates a new object by copying another object's values.
        public ConstructorTest(ConstructorTest existingObject)
        {
            this.name = existingObject.name;
            this.age = existingObject.age;

            Console.WriteLine("Copy Constructor Called");
        }

        // Constructor Chaining using this keyword
        // Calls another constructor in the same class first.
        // this refers to the current object instance.
        // Access current object's field
        public ConstructorTest(int age) : this("Unknown")
        {
            this.age = age;

            Console.WriteLine("Constructor Chaining Using this");
        }

        public void Display()
        {
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Age = {age}");
        }
    }
}
