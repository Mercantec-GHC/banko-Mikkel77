int i = 1;
//rember its a dictionary list 
Dictionary<string, List<int>>iplate = new();
iplate.Add("bankoplade1", new List<int>());
while (true)
{
    Console.WriteLine("skriv 15 tal fra pladen ind i format: første række og så den under og så den under, efter det skriv exit til at indtaste numer");
    var bankoPlates = Console.ReadLine();

#pragma warning disable CS8602 // Dereference of a possibly null reference.

    //check de første 5 10 og 15 numre i banko
    if (int.TryParse(bankoPlates, out int number))
    {
        iplate["bankoplade1"].Add(number);

        if (i == 5)
        {
            Console.WriteLine("test");
            Console.ReadLine();

        }
        else if (i == 9)
        {
            Console.WriteLine("test2");
            Console.ReadLine();
        }
        else if (i == 14)
        {
            Console.WriteLine("test3");
            Console.ReadLine();
        }
        i++;

    }
    else
    {
        Console.WriteLine("intast et gyldigt nummer");
    }

    Console.WriteLine("De indtastede numre for 'bankoplade1' er:");
    foreach (var num in iplate["bankoplade1"])
    {
        Console.WriteLine(num);
    }

    //exit'es the plate adder
    if (bankoPlates?.ToLower() == "exit")
            {
            Console.WriteLine("Plader gemt");
            break;
        }
    #pragma warning restore CS8602 // Dereference of a possibly null reference.
}

Console.WriteLine("skriv det tal som bliver sagt");
var navnetTal = Console.ReadLine();



















/*
// Creating a dictionary
Dictionary<string, int> iplate = new Dictionary<string, int>();

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