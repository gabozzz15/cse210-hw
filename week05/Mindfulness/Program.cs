using System;
using System.IO;

// NOTE (creative addition): I added a simple activity log file writer that appends each activity run
// with datetime, activity type, and duration to "activity_log.txt" in the application's working directory. This is a small "exceed requirements"
// To show the log, press option 4 in the menu below.

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflecting Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine("4) Show Activity Log");
            Console.WriteLine("5) Quit");
            Console.Write("Choose an option: ");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    RunBreathing();
                    break;
                case "2":
                    RunReflecting();
                    break;
                case "3":
                    RunListing();
                    break;
                case "4":
                    ShowLog();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static int PromptDuration()
    {
        Console.Write("Enter duration in seconds (e.g., 30): ");
        while (true)
        {
            string s = Console.ReadLine();
            if (int.TryParse(s, out int secs) && secs > 0)
            {
                return secs;
            }
            Console.Write("Please enter a valid positive integer for seconds: ");
        }
    }

    static void RunBreathing()
    {
        Console.Clear();
        string name = "Breathing Activity";
        string desc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int duration = PromptDuration();
        var activity = new BreathingActivity(name, desc, duration);
        activity.Run();
        AppendLog(name, duration);
        PauseBeforeContinue();
    }

    static void RunReflecting()
    {
        Console.Clear();
        string name = "Reflecting Activity";
        string desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int duration = PromptDuration();
        var activity = new ReflectingActivity(name, desc, duration);
        activity.Run();
        AppendLog(name, duration);
        PauseBeforeContinue();
    }

    static void RunListing()
    {
        Console.Clear();
        string name = "Listing Activity";
        string desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        int duration = PromptDuration();
        var activity = new ListingActivity(name, desc, duration);
        activity.Run();
        AppendLog(name, duration);
        PauseBeforeContinue();
    }

    static void PauseBeforeContinue()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the main menu...");
        Console.ReadLine();
    }

    static readonly string LogFile = "activity_log.txt";
    static void AppendLog(string activityName, int duration)
    {
        try
        {
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {activityName} | {duration}s";
            File.AppendAllLines(LogFile, new string[] { line });
        }
        catch
        {
            // ignore logging errors silently
        }
    }

    static void ShowLog()
    {
        Console.Clear();
        Console.WriteLine("Activity Log:");
        Console.WriteLine("-------------");
        try
        {
            if (File.Exists(LogFile))
            {
                string[] lines = File.ReadAllLines(LogFile);
                foreach (var l in lines)
                {
                    Console.WriteLine(l);
                }
            }
            else
            {
                Console.WriteLine("No activity log found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading log: {ex.Message}");
        }

        PauseBeforeContinue();
    }
}
