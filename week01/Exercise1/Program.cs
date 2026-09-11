using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your firstname?");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your lastname?");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {firstname}, {firstname} {lastname}");
    }

}