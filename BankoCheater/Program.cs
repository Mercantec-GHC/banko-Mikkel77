//for dictanary DONT DELETE
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary for at gemme bankoplader husk list int
        Dictionary<string, List<int>> bankoplate = new();
        List<int> kaldteNumre = new();
        int PlateT = 1;

        
        while (true)
        {
            Console.WriteLine($"Skriv de tal fra bankoplade {PlateT} ind i format: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 (husk mellemrum). Skriv 'exit' for at stoppe indtastning af plader:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string bankoPlates = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            // exites bango pladerne 
            if (bankoPlates?.ToLower() == "exit")
                break;

            string plateName = $"bankoplade{PlateT}";
            bankoplate.Add(plateName, new List<int>());

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type. 
            string[] numreInput = bankoPlates?.Split(" ");
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (var tal in numreInput)
            {
                if (int.TryParse(tal, out int nummer))
                {
                    bankoplate[plateName].Add(nummer);
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Console.WriteLine($"'{plateName}' gemt");
            PlateT++;
        }

        // nummer kald del
        while (true)
        {
            Console.WriteLine("Indtast kaldt nummer (eller 'exit' for at afslutte):");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string kaldInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            if (kaldInput?.ToLower() == "exit")
                break;

            if (int.TryParse(kaldInput, out int kaldtNummer))
            {
                kaldteNumre.Add(kaldtNummer);

                // sender dem til tjek hver plade for banko
                foreach (var plade in bankoplate)
                {
                    TjekRækker(plade.Key, plade.Value, kaldteNumre);
                }
            }
            else
            {
                Console.WriteLine("Intast et gyldigt tal.");
            }
        }
    }

    // Tjekker om der er banko
    static void TjekRækker(string pladeNavn, List<int> plade, List<int> kaldteNumre)
    {
        int numrePerRække = 5;
        bool[] rækkerMedBanko = new bool[3];

        // Tjek hver række 
        for (int række = 0; række < 3; række++)
        {
            int startrække = række * numrePerRække;
            bool alleTalFundet = true;

            for (int i = startrække; i < startrække + numrePerRække; i++)
            {
                if (!kaldteNumre.Contains(plade[i]))
                {
                    alleTalFundet = false;
                    break;
                }
            }

            if (alleTalFundet)
            {
                rækkerMedBanko[række] = true;
            }
        }

        // Tæller banko
        int antalRækkerMedBanko = 0;
        foreach (bool banko in rækkerMedBanko)
        {
            if (banko)
                antalRækkerMedBanko++;
        }

        // resultatetr for banko
        if (antalRækkerMedBanko == 1)
        {
            Console.WriteLine($"{pladeNavn} har banko på 1 række!");
        }
        else if (antalRækkerMedBanko == 2)
        {
            Console.WriteLine($"{pladeNavn} har banko på 2 rækker!");
        }
        else if (antalRækkerMedBanko == 3)
        {
            Console.WriteLine($"{pladeNavn} har banko på 3 rækker!");
        }
    }
}
