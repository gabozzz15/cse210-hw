using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal theJournal = new Journal();
            PromptGenerator promptGen = new PromptGenerator();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Journal Menu");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        WriteNewEntry(theJournal, promptGen);
                        break;
                    case "2":
                        theJournal.DisplayAll();
                        break;
                    case "3":
                        Console.Write("Enter filename to save to: ");
                        string saveFile = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(saveFile))
                        {
                            theJournal.SaveToFile(saveFile);
                        }
                        else
                        {
                            Console.WriteLine("Invalid filename.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter filename to load from: ");
                        string loadFile = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(loadFile))
                        {
                            theJournal.LoadFromFile(loadFile);
                        }
                        else
                        {
                            Console.WriteLine("Invalid filename.");
                        }
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Choose a number between 1 and 5.");
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
        }

        static void WriteNewEntry(Journal journal, PromptGenerator promptGen)
        {
            string prompt = promptGen.GetRandomPrompt();
            Console.WriteLine("Prompt:");
            Console.WriteLine(prompt);
            Console.WriteLine();
            Console.Write("Your response: ");
            string response = Console.ReadLine();

            string date = DateTime.Now.ToString("yyyy-MM-dd");

            Entry e = new Entry(date, prompt, response ?? "");
            journal.AddEntry(e);

            Console.WriteLine("Entry added.");
        }
    }
}
