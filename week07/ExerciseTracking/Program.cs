using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var runningActivity = new Running(DateTime.Parse("2022-11-03"), 30, 3.0);
        var cyclingActivity = new Cycling(DateTime.Parse("2022-11-03"), 30, 12.0);
        var swimmingActivity = new Swimming(DateTime.Parse("2022-11-03"), 30, 40);

        List<Activity> activities = new List<Activity>()
        {
            runningActivity,
            swimmingActivity,
            cyclingActivity,
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}