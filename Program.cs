using System;
using CSharpTrainingProject.src;

class Program
{
    static void Main(string[] args)
    {
        // To import 'TutorialOne.Run()' We have added 'using CSharpTrainingProject.src'
        // Here 'CSharpTrainingProject' is the name of this project and 'src' is the folder where we have the '01_TutorialOne.cs' file.
        TutorialOne.Run();
        TutorialTwo.Run();
        MyProgram.Run(); // This MyProgram class is present inside the 03_TutorialThree.cs file
        TestClass testClass = new TestClass();
        testClass.addNumbers();
    }
}