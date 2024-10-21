using System;
using System.Collections.Generic;

Console.WriteLine("Enter the amount of plates (max 5)");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string userInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

// Creating a dictionary
Dictionary<int, int> iplate = new Dictionary<int, int>();

int userPlates;
if (int.TryParse(userInput, out userPlates))
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