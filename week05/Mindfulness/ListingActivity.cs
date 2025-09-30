using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _rand;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _count = 0;
        _rand = new Random();
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Pick random prompt and show it
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Prompt:");
        Console.WriteLine($"  {prompt}");
        Console.WriteLine();

        // Give user a short countdown to think
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine("Start listing items. Press Enter after each item.");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int remaining = (int)(endTime - DateTime.Now).TotalMilliseconds;
            if (remaining <= 0) break;

            string line = ReadLineWithTimeout(remaining).Result;
            if (line == null)
            {
                // timeout reached
                break;
            }
            if (!string.IsNullOrWhiteSpace(line))
            {
                items.Add(line.Trim());
                Console.WriteLine($"Added ({items.Count})");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items. Great job!");
        DisplayEndingMessage();
    }

    private async Task<string> ReadLineWithTimeout(int timeoutMillis)
    {
        Task<string> readTask = Task.Run(() => Console.ReadLine());
        Task delayTask = Task.Delay(timeoutMillis);

        Task finished = await Task.WhenAny(readTask, delayTask);
        if (finished == readTask)
        {
            return readTask.Result;
        }
        else
        {
            // Timeout - do not wait for user input anymore
            return null;
        }
    }

    public string GetRandomPrompt()
    {
        int idx = _rand.Next(_prompts.Count);
        return _prompts[idx];
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}
