using System;

//A function that receives the user's year of birth, and displays his age:

int convertNumber, age;

//Get the current year
DateTime currentDate = DateTime.Now;
int currentYear = currentDate.Year;

Console.WriteLine($"Please enter the year:");
string inputUser = Console.ReadLine();

int.TryParse(inputUser, out convertNumber);

//Get absolute number
age = convertNumber - currentYear;
int absoluteValue = Math.Abs(age);

Console.WriteLine(absoluteValue);
Console.ReadLine();
