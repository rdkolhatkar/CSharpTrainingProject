using System;

namespace CSharpTrainingProject.code
{
    internal class VariablesDataLiteralsTypes
    {
        /*
         * ==============================================================
         * VALUE TYPES VS REFERENCE TYPES
         * ==============================================================
         *
         * VALUE TYPES
         * -----------
         * Value types directly store the actual value in memory.
         *
         * Examples:
         * byte, sbyte, short, int, long, float, double, decimal,
         * bool, char, struct, enum
         *
         * Scenario:
         * int age = 26;
         *
         * Memory:
         * age --> 26
         *
         * Each variable has its own copy of data.
         *
         *
         * REFERENCE TYPES
         * ---------------
         * Reference types store the memory address (reference)
         * of the actual object.
         *
         * Examples:
         * string, array, class, interface, delegate
         *
         * Scenario:
         * string name = "Ratnakar";
         *
         * Memory:
         * name --> Address --> "Ratnakar"
         *
         * Multiple variables can point to the same object.
         *
         * ==============================================================
         * DATATYPE HIERARCHY
         * ==============================================================
         *
         * Whole Numbers
         * -------------
         * sbyte
         * byte
         * short
         * ushort
         * int
         * uint
         * long
         * ulong
         *
         * Decimal Numbers
         * ---------------
         * float
         * double
         * decimal
         *
         * Other Types
         * -----------
         * char
         * bool
         * string
         * object
         *
         */

        public void DataTypes()
        {
            Console.WriteLine("========== C# DATA TYPES ==========");

            /*
             * ==========================================================
             * STRING (REFERENCE TYPE)
             * ==========================================================
             *
             * Used to store text.
             *
             * Scenario:
             * Store employee name, address, city etc.
             */

            string myName = "Ratnakar";

            Console.WriteLine($"Name : {myName}");

            // Output:
            // Name : Ratnakar


            /*
             * ==========================================================
             * BYTE
             * ==========================================================
             *
             * Size  : 1 Byte
             * Range : 0 to 255
             *
             * Used when values are always positive.
             *
             * Example:
             * Age, Marks, RGB Color values
             */

            byte num = 255;

            Console.WriteLine($"Byte Value : {num}");
            Console.WriteLine($"Byte Min : {byte.MinValue}");
            Console.WriteLine($"Byte Max : {byte.MaxValue}");

            // Output:
            // Byte Value : 255
            // Byte Min : 0
            // Byte Max : 255


            /*
             * ==========================================================
             * SBYTE
             * ==========================================================
             *
             * Size  : 1 Byte
             * Range : -128 to 127
             *
             * Difference Between byte and sbyte
             *
             * byte
             * ----
             * Stores only positive values.
             *
             * sbyte
             * -----
             * Stores both positive and negative values.
             */

            sbyte numOne = -128;

            Console.WriteLine($"SByte Value : {numOne}");
            Console.WriteLine($"SByte Min : {sbyte.MinValue}");
            Console.WriteLine($"SByte Max : {sbyte.MaxValue}");

            // Output:
            // SByte Value : -128
            // SByte Min : -128
            // SByte Max : 127


            /*
             * ==========================================================
             * SHORT
             * ==========================================================
             *
             * Size  : 2 Bytes
             * Range : -32,768 to 32,767
             *
             * Scenario:
             * Store small numbers larger than byte.
             */

            short numTwo = 32550;

            Console.WriteLine($"Short Value : {numTwo}");
            Console.WriteLine($"Short Min : {short.MinValue}");
            Console.WriteLine($"Short Max : {short.MaxValue}");

            // Output:
            // Short Value : 32550
            // Short Min : -32768
            // Short Max : 32767


            /*
             * ==========================================================
             * INT
             * ==========================================================
             *
             * Size  : 4 Bytes
             * Range : -2,147,483,648 to 2,147,483,647
             *
             * Most commonly used integer datatype.
             *
             * Scenario:
             * Employee ID
             * Age
             * Product Quantity
             */

            int myAge = 26;

            Console.WriteLine($"Age : {myAge}");
            Console.WriteLine($"Int Min : {int.MinValue}");
            Console.WriteLine($"Int Max : {int.MaxValue}");

            // Output:
            // Age : 26


            /*
             * ==========================================================
             * LONG
             * ==========================================================
             *
             * Size  : 8 Bytes
             * Used for very large numbers.
             *
             * NOTE:
             * Long values should end with L.
             */

            long phoneNumber = 919604822549L;

            Console.WriteLine($"Phone Number : {phoneNumber}");
            Console.WriteLine($"Long Min : {long.MinValue}");
            Console.WriteLine($"Long Max : {long.MaxValue}");

            // Output:
            // Phone Number : 919604822549


            /*
             * ==========================================================
             * FLOAT
             * ==========================================================
             *
             * Size : 4 Bytes
             * Precision : ~7 digits
             *
             * Must end with f or F.
             */

            float numPi = 3.1415926535f;

            Console.WriteLine($"Float Value : {numPi}");
            Console.WriteLine($"Float Min : {float.MinValue}");
            Console.WriteLine($"Float Max : {float.MaxValue}");

            // Output:
            // Float Value : 3.141593


            /*
             * ==========================================================
             * DOUBLE
             * ==========================================================
             *
             * Size : 8 Bytes
             * Precision : ~15-16 digits
             *
             * Default datatype for decimal values.
             */

            double pi = 3.141592653589793;

            Console.WriteLine($"Double Value : {pi}");
            Console.WriteLine($"Double Min : {double.MinValue}");
            Console.WriteLine($"Double Max : {double.MaxValue}");

            // Output:
            // Double Value : 3.141592653589793


            /*
             * ==========================================================
             * DECIMAL
             * ==========================================================
             *
             * Size : 16 Bytes
             * High precision datatype.
             *
             * Used for:
             * Money
             * Banking
             * Financial Calculations
             *
             * Must end with m or M.
             */

            decimal salary = 25000.75m;

            Console.WriteLine($"Salary : {salary}");
            Console.WriteLine($"Decimal Min : {decimal.MinValue}");
            Console.WriteLine($"Decimal Max : {decimal.MaxValue}");

            // Output:
            // Salary : 25000.75


            /*
             * ==========================================================
             * BOOL
             * ==========================================================
             *
             * Stores only true or false.
             */

            bool isEmployee = true;

            Console.WriteLine($"Is Employee : {isEmployee}");

            // Output:
            // Is Employee : True


            /*
             * ==========================================================
             * CHAR
             * ==========================================================
             *
             * Stores a single character.
             */

            char grade = 'A';

            Console.WriteLine($"Grade : {grade}");

            // Output:
            // Grade : A


            /*
             * ==========================================================
             * NULLABLE TYPES
             * ==========================================================
             *
             * Normally value types cannot store null.
             *
             * int age = null; // Compile Error
             *
             * Use ? operator.
             */

            int? employeeAge = null;

            Console.WriteLine($"Nullable Age : {employeeAge}");

            // Output:
            // Nullable Age :


            /*
             * ==========================================================
             * STRING METHODS
             * ==========================================================
             */

            string text = "   Welcome To C# Programming   ";

            Console.WriteLine("\n========== STRING METHODS ==========");

            // Length
            Console.WriteLine(text.Length);

            // Output:
            // 31

            // Trim
            Console.WriteLine(text.Trim());

            // Output:
            // Welcome To C# Programming

            // ToUpper
            Console.WriteLine(text.ToUpper());

            // Output:
            // WELCOME TO C# PROGRAMMING

            // ToLower
            Console.WriteLine(text.ToLower());

            // Output:
            // welcome to c# programming

            // Contains
            Console.WriteLine(text.Contains("C#"));

            // Output:
            // True

            // StartsWith
            Console.WriteLine(text.Trim().StartsWith("Welcome"));

            // Output:
            // True

            // EndsWith
            Console.WriteLine(text.Trim().EndsWith("Programming"));

            // Output:
            // True

            // Replace
            Console.WriteLine(text.Replace("Programming", "Development"));

            // Output:
            // Welcome To C# Development

            // Substring
            Console.WriteLine(text.Trim().Substring(0, 7));

            // Output:
            // Welcome

            // IndexOf
            Console.WriteLine(text.IndexOf("C#"));

            // Output:
            // Position of C#

            // Split
            string skills = "Java,C#,Python,Playwright";

            string[] skillArray = skills.Split(',');

            foreach (string skill in skillArray)
            {
                Console.WriteLine(skill);
            }

            // Output:
            // Java
            // C#
            // Python
            // Playwright

            /*
             * ==========================================================
             * STRING REVERSE
             * ==========================================================
             */

            string original = "Ratnakar";

            char[] chars = original.ToCharArray();

            Array.Reverse(chars);

            string reversed = new string(chars);

            Console.WriteLine($"Original : {original}");
            Console.WriteLine($"Reversed : {reversed}");

            // Output:
            // Original : Ratnakar
            // Reversed : rakantaR


            /*
             * ==========================================================
             * STRING NULL OR EMPTY CHECK
             * ==========================================================
             */

            string userName = "";

            Console.WriteLine(
                string.IsNullOrEmpty(userName));

            // Output:
            // True


            /*
             * ==========================================================
             * STRING NULL OR WHITESPACE CHECK
             * ==========================================================
             */

            string userInput = " ";

            Console.WriteLine(
                string.IsNullOrWhiteSpace(userInput));

            // Output:
            // True


            /*
             * ==========================================================
             * BOXING AND UNBOXING
             * ==========================================================
             *
             * Boxing
             * ------
             * Converting Value Type to Object Type.
             */

            int number = 100;

            object obj = number;

            // Unboxing

            int value = (int)obj;

            Console.WriteLine(value);

            // Output:
            // 100


            /*
             * ==========================================================
             * VAR KEYWORD
             * ==========================================================
             *
             * Compiler automatically determines datatype.
             */

            var city = "Pune";
            var pinCode = 411001;

            Console.WriteLine(city);
            Console.WriteLine(pinCode);

            // Output:
            // Pune
            // 411001


            /*
             * ==========================================================
             * OBJECT DATATYPE
             * ==========================================================
             *
             * Base type of all datatypes in C#.
             */

            object employeeName = "Ratnakar";
            object employeeId = 101;
            object employeeSalary = 50000.50m;

            Console.WriteLine(employeeName);
            Console.WriteLine(employeeId);
            Console.WriteLine(employeeSalary);

            // Output:
            // Ratnakar
            // 101
            // 50000.50
        }
    }
}