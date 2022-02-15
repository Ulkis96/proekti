using System;
using System.Collections.Generic;
using System.Linq;

namespace Listzadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while(true)
            {
                string input = Console.ReadLine();

                if (input == "Stop");
            }
            string[] commands = input.Split();

            switch (commands[0])
            {
                case "add":
                    {
                        string element = (commands[1]);
                        {
                            Console.WriteLine("Element already exist");
                        }
                        break;
                    }
                case "contains ":
                    {
                        string nameToSearch = (commands[1]);
                        if (names.Contains(nameToSearch))
                        {
                            Console.WriteLine(names.IndexOf(nameToSearch));
                        }
                        break;
                        
                    }
                case "insert index":
                    {

                    }
                case "print":
                    {
                        Console.WriteLine(string.Join(" ", names));
                    }
            }

        }
    }

    internal class input
    {
        internal static string[] Split()
        {
            throw new NotImplementedException();
        }
    }
}
