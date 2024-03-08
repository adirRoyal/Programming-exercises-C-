using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;

/*A function that will return the number of words in a string (treat the string as a sentence).
A function that will print the number of regular letters in a string (from A-Z, a-z.)
A function that will return the amount of numbers in the string (if any).
A function that will accept any signal, and return its first index in the string.
A function that will accept any signal, and return its last index in the string.
A function that will print the first word in the sentence.
A function that will print the last word in the sentence
*/
int ReturnNumberWord(string word)
{
    return word.Length;
}
int CountRegularLetters(string input)
{
    // Regular expression pattern to match letters from A-Z, a-z
    string pattern = "[a-zA-Z]";

    // Count the number of matches using Regular Expression
    int count = Regex.Matches(input, pattern).Count;
    return count;
}

int CountNumberInWord(string input)
{
    string pattern = "[0-9]";

    int count = Regex.Matches(input, pattern).Count;
    return count;
}

int FindFirstIndex(string input, char signal)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == signal)
        {
            return i;
        }
    }
    return -1; // Signal not found in the string
}
int FindLastIndex(string input, char signal)
{
    for (int i = input.Length; i >= 0; i--)
    {
        if (input[i] == signal)
        {
            return i;
        }
    }
    return -1; 
}
 void PrintFirstWord(string sentence)
{
    // Trim any leading or trailing whitespace
    sentence = sentence.Trim();

    // Find the index of the first space character
    int spaceIndex = sentence.IndexOf(' ');

    if (spaceIndex != -1)
    {
        // Extract and print the first word
        string firstWord = sentence.Substring(0, spaceIndex);
        Console.WriteLine("The first word in the sentence is: " + firstWord);
    }
    else
    {
        // If there are no spaces, the whole sentence is considered as the first word
        Console.WriteLine("The first word in the sentence is: " + sentence);
    }
}

static void PrintLastWord(string sentence)
{
    sentence = sentence.Trim();

    int spaceIndex = sentence.LastIndexOf(' ');

    if (spaceIndex != -1)
    {
        string lastWord = sentence.Substring(spaceIndex + 1);
        Console.WriteLine("The last word in the sentence is: " + lastWord);
    }
    else
    {
        Console.WriteLine("The last word in the sentence is: " + sentence);
    }
}
