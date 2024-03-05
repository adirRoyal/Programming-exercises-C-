using Microsoft.VisualBasic;
using System;
/*A program that asks the user to type in a price and a discount percentage. The program will display
to the user the price after the discount and how much money the user saved as a result of the discount.*/

double price, discount;

Console.WriteLine("Please enter the price.");
double.TryParse(Console.ReadLine(), out price);
Console.WriteLine("Please enter the discount.");
double.TryParse(Console.ReadLine(), out discount);

// Calculate the discounted price and savings
(double discountedPrice , double savings) =  DiscountCalculation(price, discount);

// Display the results to the user
Console.WriteLine($"After applying a {discount}% discount, the price is: {discountedPrice} NIS");
Console.WriteLine($"You saved: {savings} NIS");
Console.ReadLine();

static (double, double) DiscountCalculation(double price, double discount)
{
    double discountAmount = price * (discount / 100);
    double discountedPrice = price - discountAmount;
    return (discountedPrice, discountAmount);
}
