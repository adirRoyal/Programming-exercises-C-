using Microsoft.VisualBasic;
using System;

// decomposing literature
Console.WriteLine("Please enter a number:");
int number = int.Parse(Console.ReadLine());

// A. Print all the digits
Console.WriteLine("A. All the digits in the number:");
PrintAllDigits(number);

// B. Print the number of digits
Console.WriteLine("B. The number of digits in the number: " + CountDigits(number));

// C. Print the sum of all digits
Console.WriteLine("C. The sum of all the digits in the number: " + SumOfDigits(number));

// D. Print the last digit
Console.WriteLine("D. The last digit of the number: " + LastDigit(number));

// E. Print all digits that are not in the number
Console.WriteLine("E. Bonus - all the digits that are not in our number:");
PrintMissingDigits(number);

static void PrintAllDigits(int number)
{
    while (number > 0)
    {
        int digit = number % 10;
        Console.WriteLine(digit);
        number /= 10;
    }
}

static int CountDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

static int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}

static int LastDigit(int number)
{
    return number % 10;
}

static void PrintMissingDigits(int number)
{
    bool[] digitsPresent = new bool[10];
    while (number > 0)
    {
        int digit = number % 10;
        digitsPresent[digit] = true;
        number /= 10;
    }

    for (int i = 0; i < 10; i++)
    {
        if (!digitsPresent[i])
        {
            Console.WriteLine(i);
        }
    }
}
