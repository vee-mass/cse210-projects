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
    public override string ToString()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response} \nRating: {_rating}";
    }

    public string ToFileString()
{
    return $"{_date}~|~{_prompt}~|~{_response}~|~{_rating}";
}

public static Entry FromFileString(string line)
{
    string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
    if (parts.Length == 4)
    {
        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        int rating = int.Parse(parts[3]);
        return new Entry(prompt, response, date, rating);
    }
    else
    {
        throw new Exception("Invalid entry format in file.");
    }
}

}

