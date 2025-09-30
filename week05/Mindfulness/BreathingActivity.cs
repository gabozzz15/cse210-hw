using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private int _breathSecondsIn = 4;
    private int _breathSecondsOut = 4;

    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    // Run the breathing cycle until duration is reached
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(_breathSecondsIn);
            Console.WriteLine();

            if (DateTime.Now >= endTime) break;

            Console.Write("Breathe out... ");
            ShowCountDown(_breathSecondsOut);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
