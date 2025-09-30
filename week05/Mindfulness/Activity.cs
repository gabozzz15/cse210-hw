using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // seconds

    private static readonly char[] SpinnerChars = new char[] { '|', '/', '-', '\\' };

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"*** {_name} ***");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine();
        Console.Write("Get ready to begin ");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Console.Write("Returning to menu ");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        int idx = 0;
        DateTime end = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < end)
        {
            Console.Write(SpinnerChars[idx % SpinnerChars.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            idx++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

