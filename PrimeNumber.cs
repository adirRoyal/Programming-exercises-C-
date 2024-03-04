using System;
/*A function named Prime that accepts a positive integer, the function returns a true value
        if the received number is prime, and false otherwise.*/
int convertNumber;
string inputUser;
do {
    Console.WriteLine("Please enter number to check with is primary. To exit loop send 0");
    inputUser = Console.ReadLine();

    int.TryParse(inputUser, out convertNumber);


    Console.WriteLine(IsPrime(convertNumber));
}
while(inputUser != "0");
Console.ReadLine();

bool IsPrime(int number)
{
    if(number <= 1) return false;

    // Check if n is divisible by any number from 2 to its square root
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if(number % i == 0) return false;
    }
    return true;

}

/* By using the square root as the upper limit in our divisor checking loop, 
 * we can reduce the number of iterations and improve the efficiency of the algorithm.
 * This is particularly useful for large numbers, where the divisor checking process can be time-consuming.*/
