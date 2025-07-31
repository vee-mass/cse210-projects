using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public virtual void RunBreathingActivity()
    {
        DisplayStartMessage();
        int timePassed = 0;
        int breathTime = 4;

        while (timePassed < Duration)
        {
            Console.WriteLine("Breathe In...");
            ShowCountDown(breathTime);
            timePassed += breathTime;

            if (timePassed >= Duration) break;

            Console.WriteLine("Breath out...");
            ShowCountDown(breathTime);
            timePassed += breathTime;
        }
        DisplayEndMessage();
    }
}