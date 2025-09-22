using System;

class Program
{
    static void Main(string[] args)
    {
        // creating a scripture reference and scripture text
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.\n");

        while (!scripture.IsCompletelyHidden())
        {
            // Display current scripture state
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words and clear console
            scripture.HideRandomWords(3);
            Console.Clear();
        }

        // Display final state if all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden! Great job memorizing!");
        }

        Console.WriteLine("\nThank you for using Scripture Memorizer!");
    }
}