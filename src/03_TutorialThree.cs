using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.src
{
    public class MyProgram
    {
        public void getData()
        {
            Console.WriteLine("I am inside the getData Method");

        }
        public static void Run()
        {
            // To call any method inside the class, first we have to create the Object of that class and then call that method
            MyProgram myProgram = new MyProgram();
            myProgram.getData();

        }
    }
}
