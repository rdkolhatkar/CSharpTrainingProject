using System;

namespace CSharpTrainingProject.src
{
    public class TutorialTwo
    {

        public static void Run()
        {
            Console.WriteLine("Tutorial Two");
            // Creating an integer
            int a = 4;
            Console.WriteLine("Number is " + a);
            // Creating a String
            String name = "Rahul";
            Console.WriteLine("Name is " + name);
            // Writing an evaluation String (modern way of writing output statement)
            Console.WriteLine($"Name is {name}");

            // Dynamic data type 'var'
            // If we are not sure about the data type of any value then we can use 'var' it will decide the data type of any value in runtime
            var age = 25;
            var myAge = "25"; 
            Console.WriteLine("Name is " + name);
            // In C#, var is only used for type inference at compile time. You can reassign values, but the reassigned value must be of the same inferred type.
            var person = "John";
            person = "David";   // Valid
            var num = 1;
            num = 2;
            Console.WriteLine(person); // Output : David
            Console.WriteLine(num); // Output : 2
            // 'dynamic' data type in C#
            dynamic heighjt = 13.2;
            heighjt = 24.1;
            dynamic newHeight = "Ram";
            newHeight = "Raghav";
            Console.WriteLine(heighjt); // Output : 24.1
            Console.WriteLine(newHeight); // Output : Raghav
        }
    }
}