using Microsoft.VisualBasic;
using System;

/*A program that asks the user to enter names of students and their grades,
until he enters the word stop (in the student's name). Then the program will print the following:
1. How many students in total were admitted.
2. The grade point average of all admitted students.
3. The name of the student with the highest grade.
4. How many students passed with a passing grade (above 55).
5. How many students failed.
*/

int totalStudents = 0, passedCount = 0, failedCount = 0;
double totalScore = 0, highestGrade = 0;
string highestGradeStudent = "";


while (true)
{
    Console.WriteLine("Enter student's name (or 'stop' to finish): ");
    string name = Console.ReadLine();
    if (name.ToLower() == "stop")
        break;

    Console.WriteLine("Enter student's grade:");
    double grade;
    if (!double.TryParse(Console.ReadLine(), out grade))
    {
        Console.WriteLine("Invalid input. Please enter a valid grade.");
        continue;
    }

    //update total students
    totalStudents++;

    //update total score
    totalScore += grade;

    if(grade > highestGrade)
    {
        highestGrade = grade;
        highestGradeStudent = name;
    }

    //check passing or failing grade
    if (grade > 55)
        passedCount++;
    else
        failedCount++;
}

// Calculate average score
double averageScore = totalStudents != 0 ? totalScore / totalStudents : 0;

//output result
Console.WriteLine("1. Total students admitted: " + totalStudents);
Console.WriteLine("2. Average score: " + averageScore);
Console.WriteLine("3. Student with highest grade: " + highestGradeStudent);
Console.WriteLine("4. Students passed: " + passedCount);
Console.WriteLine("5. Students failed: " + failedCount);


