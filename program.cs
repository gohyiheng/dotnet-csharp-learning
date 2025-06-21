// use class from system namespace
using System;
// container HellowWord for classes and other namespace
namespace HelloWorld
{
    // container for data and methods, class name is Program
  class Program
    {
        static void Main(string[] args)
        {
            // console class of system namespace, writeLine is a method to print text
            // Use System.Console.WriteLine if not using System.
            Console.WriteLine("Hello World!");
            // able to have multiple write line as well as do math calc
            Console.WriteLine(4 + 3 * 2 / 2);
            // Console.Write prints but does not add a new line 
            Console.Write("i will ");
            Console.Write("be on the same line\n");
            Console.WriteLine("you will need to manually add a new line using '\\n' ");

            // variables 
            string name = "test user";
            int myNum = 123; // frpm ~ -2b to 2b
            /* other type inclues 
                long - whole numbers from ~ -9quintillion to 9quintillion end value with L -> long longNum = 1555555555L;
                float - fractional number good for 6-7decimals end value with F -> float floatNum = 5.123F; float/double can also use floating point -> float f1 = 35e3F;
                double - fractional number good for 15 decimals end value with D -> double doubleNum = 5.123456789D;
                char surrounded by '' instead of "", single character
                bool - true/false
            */
            // able to overwrite value
            myNum = 456;
            // able to combine text with value 
            Console.WriteLine(name + "" + myNum);
            // or interpolation 
            Console.WriteLine($"{myNum} {name}");

            // constant turns the variable into read only 
            const int fixedNum = 999; // must be declared with a value
                                      // fixedNum = 123;  error CS0131: The left-hand side of an assignment must be a variable, property or indexer

            // able to use + to add 1 var to another 
            int newNum = fixedNum - myNum;
            Console.WriteLine("new num: " + newNum);

            // display multiple var of same type seperated by comma
            int x = 1, y = 2, z = 3;
            string a = "a", b = "b", c = "c";
            System.Console.WriteLine(x + y + z + ", " + a + b + c);
            // or same value to multiple var
            x = y = z = 1;
            System.Console.WriteLine(x + y + z);
            Console.WriteLine("testL" + 5 / 10);
            // all var must be indentified with unique names
            /* rules 
            
                Names can contain letters, digits and the underscore character (_)
                Names must begin with a letter or underscore
                Names should start with a lowercase letter, and cannot contain whitespace
                Names are case-sensitive ("myVar" and "myvar" are different variables)
                Reserved words (like C# keywords, such as int or double) cannot be used as names
            */


            // type casting 
            /*
                Implicit cast: convert smaller type to larger type based on bytes automatic
                    char -> int -> long -> float -> double

                        int myInt = 9;
                        double myDouble = myInt; auto cast int to double

                Explicit cast:  converting a larger type to a smaller size type
                    double -> float -> long -> int -> char

                        double myDouble = 9.78;
                        int myInt = (int) myDouble; manual cast double to int -> myInt value is now 9 instead of 9.78

                type conversion:
                    Console.WriteLine(Convert.ToString(myInt));    // convert int to string
                    Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
                    Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
                    Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            */
            Console.Write("Good Morning"); Console.WriteLine("Have a nice day!");
            int result = 3 + 1 * 5 / 2;
            System.Console.WriteLine(result);
            // console readLine gets user input 
            Console.Write("Enter your username: ");
            string userName = Console.ReadLine(); //readline returns a string use type conversion to convert
            System.Console.WriteLine("username is: " + userName);
            Console.Write("Enter your age: ");
            int age = 1;
            try // exceptions used in cases where things might break like converting string to int on user input but the user enters a string instead of numbers
            {
                age = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("your age is: " + age);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error:" + e);
            }

            // Operators
            /*
                + 
                -
                *
                /
                %
                ++ 
                --
            */

            // Assignments += adds a value to a varable -> x +=3 -> x = x + 3

            /* Math class
            Math.Max(5,10); -> finds the highest value
            Math.Min(x,y)
            Math.Sqrt(x)
            Math.Abs(x) -> returns +ve value
            Math.Round(x) -> nearest whole
            */

            /* Strings
            .Length -> returns length of string
            .ToUpper() -> returns copy of string to uppercase
            .ToLower() -> returns copy of string to lowercase

            Concatenation
                string conc = str1 + str2;
                string conc = string.Concat(str1, str2);

            Interpolation - introduced in c#6
                string interpo = $"Interpolated string: {str1} {str2}";

            Accessing strings
                str[0] returns first character in the string, str[1] return second character etc
                str.IndexOf("x") returns index of x in the string first
                str.Substring("x") returns a new string starting from the first time x appears in the string 

            Special characters
                \ -> escapes the special string character 
                    \\ results in \ 
                    \" results in "
                \n -> newline
                \\n -> prints \n
                \t -> tab
                \b -> backspace

            */
            // if, else. else if
            if (age < 10)
                System.Console.WriteLine($"{age} is lesser than 10");
            else if (age < 20)
                System.Console.WriteLine($"{age} is lesser than 20");
            else
                System.Console.WriteLine($"{age} is too old");

            //short hand if else variable = (condition) ? expressionTrue :  expressionFalse;
            System.Console.WriteLine((age < 10) ? "age is less than 10" : "age is larger than 10");

            // switch 
            int switchInt = 20;

            switch (switchInt)
            {
                case 1:
                    System.Console.WriteLine("case 1");
                    break;
                case 2:
                    System.Console.WriteLine("case 2");
                    break;
                case 3:
                    System.Console.WriteLine("case 3");
                    break;
                case 12: // runs if switchInt is 12
                    System.Console.WriteLine("case 20");
                    break;
                default: // runs if no other cases are found
                    System.Console.WriteLine("Default case");
                    break;
            }

            // while 
            int whileCondition = 6;
            while (whileCondition < 8)
            {
                System.Console.WriteLine("while: " + whileCondition);
                whileCondition++;
            }

            // do while - always executes the do once even though the while might not be true
            do
            {
                System.Console.WriteLine("do while: " + whileCondition);
                whileCondition++;
            }
            while (whileCondition < 8);

        }
    }
}