using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool isRunning = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (isRunning)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. View Journal Statistics (Exceeds Requirements)");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            string userChoice = Console.ReadLine();
            Console.WriteLine();

            switch (userChoice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("> ");
                    string userResponse = Console.ReadLine();
                    string currentDate = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry
                    {
                        _date = currentDate,
                        _promptText = randomPrompt,
                        _entryText = userResponse
                    };

                    journal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "5":
                    int totalWords = journal.GetTotalWordCount();
                    Console.WriteLine($"Total entries: {journal._entries.Count}");
                    Console.WriteLine($"Total word count across all entries: {totalWords} words\n");
                    break;

                case "6":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please enter a number from 1 to 6.\n");
                    break;
            }
        }
    }
}