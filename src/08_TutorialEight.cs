using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.src
{
    public class ArraysTest
    {
        // Array stores the collection of elements
        String[] strArray = { "Hello", "How Are You", "Ratnakar", "Kolhatkar" };
        int[] nums = { 1, 2, 3, 4, 5 };

        // Creating array with definite memory
        String[] a = new String[4];
        // Class body can contain declarations (fields, methods, properties).
        // String[] a = new String[4]; // ✅ field declaration + initialization

        // Executable statements are not allowed directly in a class.
        // a[0] = "Hi"; // ❌ assignment statement

        // Put assignments inside a constructor or method.
        public void setArrayData()
        {
            a[0] = "Hi";
            a[1] = "Hello";
            a[2] = "How";
            a[3] = "Hey";
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);

            // Iterating on Array Using for loop
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);

                // Check if "Ratnakar" is present in the array
                if (strArray[i] == "Ratnakar")
                {
                    Console.WriteLine("Match found");
                    break;
                }
            }
        }
    }

}
