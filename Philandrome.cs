using System;
//segment Code that checks if the string is a philandrome.

string inputUser;

Console.WriteLine("Please enter string to check if it's philandrome.");
inputUser = Console.ReadLine();

Console.WriteLine(IsPalindrome(inputUser));
Console.ReadLine();

bool IsPalindrome(string myString)
{
    int a = 0;
    int b = myString.Length - 1;

    while (a < b)
    {
        if (myString[a] != myString[b]) return false;
        a++;
        b--;
    }
    return true;
}
