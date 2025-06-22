// See https://aka.ms/new-console-template for more information
// Random dice = new(); // stateful - creating an instance of a class
// int roll = dice.Next(1, 7);

// Console.WriteLine(roll);

// stateless methods are static methods - work w/o referencing or changing values stored in memory
// stateful method (instance) - depend or modify current state (stored in memory)

//int result = Random.Next(); 
/*
- void (finish the function and end 'quietly')
- way for a method to communicate back to the code that calls the method
- when calling a method that returns a value -> assign the return value to a 
int returnValue = dice.Next(1,7) // assign return vale
Console.Write(dice.Next(1,7)) // prints the value without assigning
*/

/* overload methods
- enable calling of method with or without arguments 
- defined with multiple method signatures e.g Console.WriteLine() has 19 different overloaded version
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

basically invokes 3 different overloaded version of the WriteLine method, int, null, string etc
*/

// Random dice = new Random();
// int roll1 = dice.Next(); // range of +ve ints
// int roll2 = dice.Next(101); // to 100
// int roll3 = dice.Next(50, 101); // between 50 - 100

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice.Next()

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// -----------------------------------------------------------------

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// if (total >= 15)
// {
//     Console.WriteLine("You win");
// }

// if (total < 15)
// {
//     System.Console.WriteLine("you lose");
// }

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3)) 
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// }

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (result)
// {
//     Console.WriteLine("What does the fox say?");
// }

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
//     Console.WriteLine($"Your total including the bonus: {total}");
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here

// if (daysUntilExpiration < 10)
// {
//     if (daysUntilExpiration < 5)
//     {
//         System.Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//         System.Console.WriteLine("Renew now and save 10%!");
//     }
//     else if (daysUntilExpiration == 1)
//     {
//         System.Console.WriteLine("Your subscription expires within a day!");
//         System.Console.WriteLine("Renew now and save 20%!");
//     }
//     else
//     {
//         System.Console.WriteLine("Your subscription will expire soon. Renew now!");
//     }

// }
// else if (daysUntilExpiration == 0)
// {
//     System.Console.WriteLine("Your subscription has expired.");
// }

// -----------------------------------------------------------------

//string[] fraudIds = new string[5]; // first string[] sets the string array and [5] tells us that the array has 5 index
// able to use other primatives such as int or bool 

// fraudIds[0] = "123";
// fraudIds[1] = "456";
// fraudIds[2] = "789";
// fraudIds[3] = "999";
// fraudIds[4] = "111";
// fraudIds[5] = "D000";  Index was outside the bounds of the array.

// string[] fraudIds = ["123", "456", "789"];

// // access based on index
// System.Console.WriteLine($"First fraud detected: {fraudIds[0]}");
// System.Console.WriteLine($"Second fraud detected: {fraudIds[1]}");
// System.Console.WriteLine($"Third fraud detected: {fraudIds[2]}");

// fraudIds[0] = "000";
// System.Console.WriteLine($"Reassigned fruad: {fraudIds[0]}");

// System.Console.WriteLine($"There are {fraudIds.Length} fruads to process");

// // access based on iteration
// foreach (string fraudId in fraudIds)
// {
//     System.Console.WriteLine(fraudId);
// }

// int[] peanuts = { 1, 2, 3, 4, 5, };
// int sum = 0;
// int count = 0;
// foreach (int peanut in peanuts)
// {
//     sum += peanut;
//     count++;
// }
// System.Console.WriteLine($"Total sum is: {sum}");
// System.Console.WriteLine($"There are {count} items and the total is {sum}");

// System.Console.WriteLine("---------------------------------------");

// string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3303", "C235", "B179" };
// foreach (string orderId in orderIds)
// {
//     if (orderId.StartsWith("B"))
//     {
//         System.Console.WriteLine(orderId);
//     }
// }


// -----------------------------------------------------------------
// Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
// begin with an alphabetical letter or an underscore, underscore character to start a variable name is typically reserved for private instance fields.
//  NOT be a C# keyword,  case-sensitive
// Variable names should use camel case,

/*
    code counts the number of times a char appears in the string and prints 
    it to console
*/
// string str = "The quick brown fox jumps over the lazy dog.";

// char[] charMessage = str.ToCharArray();
// Array.Reverse(charMessage);

// int x = 0; // letterCoubt

// foreach (char i in charMessage) // letter
// {
//     if (i == 'o')
//     {
//         x++;
//     }
// }

// string new_message = new String(charMessage);

// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {x} times.");

// -----------------------------------------------------------------

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// Console.WriteLine(myValue != "a");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
// // These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50; // if sale amt > 1000 -> true: return 100 else return 50
// Console.WriteLine($"Discount: {discount}");

// write code to display the result of a coin flip 

// Random coinFlip = new();
// int flip = coinFlip.Next(2);
// System.Console.WriteLine($"The coin landed on: {(flip == 0 ? "Heads" : "Tails")}");

// string permission = "Manager";
// int level = 10;

// if (permission == "Admin")
// {
//     System.Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
// }
// else if (permission == "Manager")
// {
//     System.Console.WriteLine(level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
// }
// else
// {
//     System.Console.WriteLine("You do not have sufficient privileges.");
// }

// -----------------------------------------------------------------

// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }
// Console.WriteLine($"Outside the code block: {value}"); error CS0103: The name 'value' does not exist in the current context

// Code sample 1
// bool flag = true;
// int value;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}"); error CS0165: Use of unassigned local variable 'value' 
// since the flag can either be true or false thus value would need to be declared a value

// Code sample 2
// int value;

// if (true)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");
// value would always be 10 since if statements always runs

// bool flag = true;
// if (flag) Console.WriteLine(flag); // only for single line if code however not as readable

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;
// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//     {
//        found = true;
//     }
// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

// -----------------------------------------------------------------

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// string productType = product[0];

// switch (productType)
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// string productColor = product[1];

// switch (productColor)
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// string productSize = product[2];

// switch (productSize)
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// -----------------------------------------------------------------