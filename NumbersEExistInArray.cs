using Microsoft.VisualBasic;
using System;
/*A function (operation), which receives an array of integers. The function will check whether there are any
        The numbers between 0 and 9 (inclusive) and if yes, return true. If not, return false.*/

int[] testNumbers1 = { 0, 2, 6, 4, 5, 3, 7, 8, 9, 1 };
int[] testNumbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


Console.WriteLine(CheckIfBitween0_9(testNumbers1));
Console.WriteLine(CheckIfBitween0_9(testNumbers2));

Console.ReadLine();


bool CheckIfBitween0_9(int[] arryOfInt)
{
    bool[] digitsFound = new bool[10]; // array to keep track of which digits are found

    foreach (int num in arryOfInt)
    {
        if (num >= 0 && num <= 9)
        {
            digitsFound[num] = true; // mark the digit as found
        }
    }
    // check if all digits from 0 to 9 are found
    for (int i = 0; i < 10; i++)
    {
        if (!digitsFound[i])
        {
            return false; // if any digit is not found, return false
        }
    }
    return true; // all digits are found
}
