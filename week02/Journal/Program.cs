
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>()
        {
            "What am I grateful for today? Starting your day with gratitude can help you shift your focus to the positive things in your life.",
            "What do I want to accomplish today?",
            "How do I want to feel today?",
            "What can I do today to take care of myself?",
            "What am I looking forward to today?",
        };

        Random random = new Random();
        Journal journal = new Journal();

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    int index = random.Next(prompts.Count);
                    string prompt = prompts[index];
                    Console.WriteLine($"\n{prompt}");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    // Get rating from user
                    int rating;
                    Console.Write("Rate your day from 1 to 5: ");
                    while (!int.TryParse(Console.ReadLine(), out rating) || rating < 1 || rating > 5)
                    {
                        Console.Write("Invalid input. Please enter a number between 1 and 5: ");
                    }

                    Entry entry = new Entry(prompt, response, date, rating);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added!");
                    break;

                case "2":
                    Console.WriteLine("\nYour Journal Entries:");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved!");
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded!");
                    break;

                case "5":
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    break;
            }
        }
    }
}
