using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class PromptGenerator
    {
        private List<string> _prompts = new List<string>();
        private Random _random = new Random();

        public PromptGenerator()
        {
            // Prompts
            _prompts.Add("Who was the most interesting person I interacted with today?");
            _prompts.Add("What was the best part of my day?");
            _prompts.Add("How did I see the hand of the Lord in my life today?");
            _prompts.Add("What was the strongest emotion I felt today?");
            _prompts.Add("If I had one thing I could do over today, what would it be?");
            _prompts.Add("What am I grateful for today?");
            _prompts.Add("What small victory did I have today?");
        }

        public string GetRandomPrompt()
        {
            if (_prompts.Count == 0) return "";
            int index = _random.Next(0, _prompts.Count);
            return _prompts[index];
        }
    }
}
