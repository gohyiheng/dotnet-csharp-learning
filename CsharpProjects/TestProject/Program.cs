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