using System;
using System.Diagnostics;

/* 
* Just like in Java we have the 'import' keyword to import the packages, similarly in C# we have 'using' keyword
* 'namespace' in C# is just like a package in Java.
* If we have to import the code from this "01_TutorialOne.cs" file into some another class then we have to import this namespace.
*/
namespace CSharpTrainingProject.src
{

    public class TutorialOne
    {
        public static void Run()
        {
            Console.WriteLine("Tutorial One"); // Basic Print Statement in C# using Console class in System namespace
            System.Console.WriteLine("This is another way to Print Tutorial One"); // Basic Print Statement called using System namespace

            // Basic Print Statement in C# using Debug class
            Debug.WriteLine("Printing Tutorial One with Debug class");
            // Debug class is present inside 'System.Diagnostics' namespace
            System.Diagnostics.Debug.WriteLine("Printing Tutorial One with System.Diagnostics.Debug");
            // Important Note: Print Statements written with 'Debug or System.Diagnostics.Debug' will not be printed in Windows console or OS console, it will get printed in debug console of visual studio.
        }
    }

}