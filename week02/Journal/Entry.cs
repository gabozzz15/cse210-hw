using System;

namespace JournalApp
{
    public class Entry
    {
        private string _date;
        private string _promptText;
        private string _entryText;

        public Entry(string date, string promptText, string entryText)
        {
            _date = date;
            _promptText = promptText;
            _entryText = entryText;
        }

        // Show in console
        public void Display()
        {
            Console.WriteLine("Date: " + _date);
            Console.WriteLine("Prompt: " + _promptText);
            Console.WriteLine("Entry: " + _entryText);
            Console.WriteLine(); 
        }

        public string ToFileString(string separator)
        {
            return $"{_date}{separator}{_promptText}{separator}{_entryText}";
        }

        public static Entry FromFileString(string line, string separator)
        {
            string[] parts = line.Split(new string[] { separator }, StringSplitOptions.None);
            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];

                // Join the rest with the condition
                if (parts.Length > 3)
                {
                    for (int i = 3; i < parts.Length; i++)
                    {
                        entryText += separator + parts[i];
                    }
                }

                return new Entry(date, prompt, entryText);
            }
            else
            {
                return null;
            }
        }
    }
}

