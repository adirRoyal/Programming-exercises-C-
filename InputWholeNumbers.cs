using Microsoft.VisualBasic;
using System;
/*A segment in a main operation that will take in integers.
    The input will end when there is a number 0.*/

int totalNumbers = 0, evenNumbers = 0, positiveNumbers = 0, inputInt;

do
{
    Console.WriteLine("Please enter the numbers.");
    int.TryParse(Console.ReadLine(), out inputInt);

    if (inputInt != 0)
    {
        totalNumbers++;
    }
    if (inputInt > 0)
    {
        positiveNumbers++;
        if (inputInt % 2 == 0)
        {
            evenNumbers++;
        }
    }
}
while (inputInt != 0);

Console.WriteLine($"Total were absorbed {totalNumbers} Numbers, even numbers {evenNumbers} , and positive number {positiveNumbers}");
Console.ReadLine();


