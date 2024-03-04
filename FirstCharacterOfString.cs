using System;

//A function that receives a string from the user, and returns the first character:

Console.WriteLine($"Please enter the string:");
string inputUser = Console.ReadLine();

//Get first Character
string firstChar = inputUser.Substring(0, 1);

Console.WriteLine($"The first character of {inputUser} is {firstChar}");
Console.ReadLine();
