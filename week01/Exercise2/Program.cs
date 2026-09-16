using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        // Create a variable for the letter grade
        string letter;

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Display the letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // Determine if the student passed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You can do better next time!");
        }
    }
}

    