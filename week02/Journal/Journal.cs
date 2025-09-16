using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            if (newEntry != null)
            {
                _entries.Add(newEntry);
            }
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
                return;
            }

            foreach (var e in _entries)
            {
                e.Display();
            }
        }

        public void SaveToFile(string file)
        {
            string separator = "|-|";
            try
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    foreach (var e in _entries)
                    {
                        sw.WriteLine(e.ToFileString(separator));
                    }
                }
                Console.WriteLine($"Journal saved to {file}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving file: " + ex.Message);
            }
        }

        public void LoadFromFile(string file)
        {
            string separator = "|-|";
            try
            {
                if (!File.Exists(file))
                {
                    Console.WriteLine("File not found: " + file);
                    return;
                }

                List<Entry> loaded = new List<Entry>();
                string[] lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    Entry e = Entry.FromFileString(line, separator);
                    if (e != null)
                    {
                        loaded.Add(e);
                    }
                }

                _entries = loaded;
                Console.WriteLine($"Journal loaded from {file} ({_entries.Count} entries).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading file: " + ex.Message);
            }
        }
    }
}
