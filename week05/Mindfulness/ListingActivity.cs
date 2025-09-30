using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _count = 0;
        _prompts = new List<string>();
    }

    public void Run()
    {
    }

    public void GetRandomPrompt()
    {
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}
