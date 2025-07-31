using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void RunListingActivity()
    {
        DisplayStartMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        var responses = new List<string>();

        Stopwatch stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < Duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(response))
            {
                break;
            }

            responses.Add(response);
        }

        stopwatch.Stop();

        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndMessage();
    }
}
