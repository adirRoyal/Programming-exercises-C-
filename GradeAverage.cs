/*Create four variables, into which a user will enter four scores. after the
            The reception, show the average of the four scores.*/

int convertNumber;
int[] grades = {1,2,3,4};
float average = 0;
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Please enter score{grades[i]}:");
    string inputUser = Console.ReadLine();

    int.TryParse(inputUser, out convertNumber);

    //adding up the scores 
    average += convertNumber;
}
//Create average 
average /= grades.Length;

Console.WriteLine($"The average is : {average}");
Console.ReadLine();
