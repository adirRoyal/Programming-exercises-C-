using Microsoft.VisualBasic;
using System;
//(function) that receives a number from the user, and displays a numerical triangle

int inputInt = 0;

Console.WriteLine("Please enter the Range = ");
int.TryParse(Console.ReadLine(), out inputInt);

DisplayNumericalTriangle(inputInt);

Console.ReadLine();


void DisplayNumericalTriangle(int rangeTriangle)
{
    for (int startPoint = 1; startPoint <= rangeTriangle; startPoint++)
    {
        for(int j =1; j <= rangeTriangle - startPoint; j++)
        {
            Console.Write(" ");
        }
        for(int nextPoint = 1; nextPoint <= startPoint; nextPoint++)
        {
            Console.Write(nextPoint);
        }
        for (int endPoint = startPoint - 1; endPoint >= 1; endPoint--)
        {
            Console.Write(endPoint);
        }
        Console.WriteLine();
    }
}

