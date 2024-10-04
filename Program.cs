using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_6_namn_sortering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = InitializeNames();
            DisplayNames("Original list:", names);

            names.Sort(); // sorterar namnen i  alphabetsordning
            DisplayNames("\nSorted list:", names);

            SearchName(names);
            Console.ReadKey();
        }

        Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
            Console.ReadKey();
        }
    }
}