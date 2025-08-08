using System;

class Program
{
    static void Main(string[] args)
    {
        // Added a level system, every 500 points increases your level.
        
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
