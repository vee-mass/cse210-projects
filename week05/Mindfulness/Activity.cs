using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string Name => _name;
    public string Description => _description;
    public int Duration => _duration;

    public virtual void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner();
    }

    public virtual void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done! You have completed the {_name} for {_duration} seconds.");
        ShowSpinner();
    }

    protected void ShowSpinner()
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < 10; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
