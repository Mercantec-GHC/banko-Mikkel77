int i = 1;
Dictionary<string, List<int>> iplate = new();  // Dictionary to store the banko plates
iplate.Add("bankoplade1", new List<int>());  // Initialize with an empty list

while (true)
{
    Console.WriteLine("Skriv 15 tal fra pladen ind i format: første række og så den under og så den under. Skriv 'exit' for at afslutte indtastningen.");
    var bankoPlates = Console.ReadLine();

    // Check for 'exit' input
    if (bankoPlates?.ToLower() == "exit")
    {
        Console.WriteLine("Plader gemt");
        break;  // Exit the loop
    }

    // Check if input is a valid number
    if (int.TryParse(bankoPlates, out int number))
    {
        // Add the valid number to the banko plate
        iplate["bankoplade1"].Add(number);

        // Check specific i values
        if (i == 5)
        {
            Console.WriteLine("Test");
        }
        else if (i == 9)
        {
            Console.WriteLine("Test2");
        }
        else if (i == 14)
        {
            Console.WriteLine("Test3");
        }

        // Increment counter
        i++;

        // Stop after 15 numbers are entered
        if (i > 15)
        {
            Console.WriteLine("Du har indtastet alle 15 tal.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Indtast venligst et gyldigt nummer.");
    }
}

// Output the collected numbers
Console.WriteLine("De indtastede numre for 'bankoplade1' er:");
foreach (var num in iplate["bankoplade1"])
{
    Console.WriteLine(num);
}

Console.WriteLine("Skriv det tal som bliver sagt");
var navnettal = Console.ReadLine();
