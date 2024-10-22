while (true)
{
    Console.WriteLine("Skriv 15 tal fra pladen ind i format: første række og så den under og så den under, efter det skriv 'exit' for at afslutte indtastningen.");
    var bankoPlates = Console.ReadLine();

    if (bankoPlates?.ToLower() == "exit")
    {
        Console.WriteLine("Plader gemt");
        break;  // Exit the while loop if "exit" is typed
    }

    // Check the first 5, 10, and 15 numbers in the plate
    for (int i = 1; i <= 15; i++)
    {
        if (i == 5)
        {
            Console.WriteLine("Test");
        }
        else if (i == 10)
        {
            Console.WriteLine("Test2");
        }
        else if (i == 15)
        {
            Console.WriteLine("Test3");
        }
    }
}

    #pragma warning restore CS8602 // Dereference of a possibly null reference.

Console.WriteLine("skriv det tal som er bliver sagt");
Console.ReadLine();




/*
// Creating a dictionary
Dictionary<int, int> iplate = new Dictionary<int, int>();

int userPlates;
if (int.TryParse(iplate, out userPlates))
{
    if (userPlates >= 1 && userPlates <= 5)

        for (int id = 1; id <= 5; id++)
        {
            if (id == userPlates)
            {
                Console.WriteLine($"du har valgt {userPlates} plader");
                //WIP
                iplate.Add(id, userPlates);
                foreach (KeyValuePair<int, int> ele1 in iplate)
                {
                    Console.WriteLine("{0} and {1}",
                              ele1.Key, ele1.Value);
                }
                Console.WriteLine();
            }
        }
    else
    {
        Console.WriteLine("something went wrong restart the program");
    }
}
*/