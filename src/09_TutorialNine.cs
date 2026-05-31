using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrainingProject.src
{
    public class TestCollections
    {
        public void testArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hi");
            arrayList.Add("Hello");
            arrayList.Add("Hey");
            arrayList.Add("Hoo");

            // Printing elements from ArrayList using foreach loop or enhanced for loop
            foreach(String item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine(arrayList.Contains("Hey")); // Output : true
            }

        }
    }
}
