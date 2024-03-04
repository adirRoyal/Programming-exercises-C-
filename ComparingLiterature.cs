using System;
/*A function that receives a three-digit number from the user, and checks whether
                    All digits in it are equal*/
int convertNumber, units, tens, hundreds;
bool isEqual;
Console.WriteLine($"Please enter Triple digits: Like (777)");
string inputUser = Console.ReadLine();

int.TryParse( inputUser, out convertNumber);

units = convertNumber % 10;
tens = (convertNumber % 100)/10;
hundreds = convertNumber / 100;

if(units == tens && tens == hundreds)
{
    isEqual = true;
}
else
{
    isEqual = false;
}

Console.WriteLine(isEqual);
Console.ReadLine();
