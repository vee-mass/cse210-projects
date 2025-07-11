using System;

public class Entry
{
    private string _prompt;
    private string _response;
    private string _date;
     private int _rating;

    public Entry(string prompt, string response, string date, int rating)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
        _rating = rating;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Rating: {_rating}");
        Console.WriteLine();
    }
    public string GetPrompt() => _prompt;
    public string GetResponse() => _response;
    public string GetDate() => _date;
}
