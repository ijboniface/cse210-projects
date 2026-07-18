using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
         EXCEEDING REQUIREMENTS

         1. Program stores multiple scriptures.
         2. Randomly chooses one scripture every run.
         3. Only hides words that are still visible.
        */

        List<Scripture> library = new List<Scripture>();

        library.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."
            )
        );

        library.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths."
            )
        );

        library.Add(
            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."
            )
        );

        Random random = new Random();

        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue or type quit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}