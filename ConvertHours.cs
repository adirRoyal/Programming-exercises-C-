/*Create a variable and ask the user to enter hours into it. after recording,
                  Convert hours to minutes and seconds.*/

int convertNumber, hour, minute, second;

Console.WriteLine("Please enter hours");
string numberToConver = Console.ReadLine();

int.TryParse(numberToConver, out convertNumber);

//Convert hours to minutes and seconds
hour = convertNumber;
minute = convertNumber * 60;
second = (convertNumber * 60) * 60;


Console.WriteLine($"There are {minute} minutes and {second} seconds in {hour}!");
Console.ReadLine();
