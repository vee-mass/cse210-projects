using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Cause Of WW2");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}