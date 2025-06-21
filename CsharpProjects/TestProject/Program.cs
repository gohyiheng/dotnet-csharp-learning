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
