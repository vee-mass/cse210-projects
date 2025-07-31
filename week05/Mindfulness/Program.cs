using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectionActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    keepRunning = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static int GetDurationFromUser()
    {
        int duration;
        while (true)
        {
            Console.Write("Enter duration of the activity in seconds: ");
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
                return duration;
            Console.WriteLine("Please enter a positive integer for the duration.");
        }
    }

    static void RunBreathingActivity()
    {
        int duration = GetDurationFromUser();
        var breathing = new BreathingActivity(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly.",
            duration);
        breathing.RunBreathingActivity();
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }

    static void RunReflectionActivity()
    {
        int duration = GetDurationFromUser();
        var reflection = new ReflectionActivity(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you showed strength and resilience.",
            duration);
        reflection.RunReflectionActivity();
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }

    static void RunListingActivity()
    {
        int duration = GetDurationFromUser();
        var listing = new ListingActivity(
            "Listing Activity",
            "This activity will help you focus by having you list positive things in your life.",
            duration);
        listing.RunListingActivity();
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }
}
