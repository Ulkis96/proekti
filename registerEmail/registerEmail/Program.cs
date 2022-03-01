using System;
using System.Collections.Generic;

namespace registerEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Email = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split();

            while (true)
            {

                if (input[0] == "Stop")
                {
                    break;
                }

                if (input[0].ToLower() == "Add")
                {
                    if (!Email.ContainsKey(input[1]))
                    {
                        Email.Add(input[1], input[2]);
                    }
                    else
                    {
                        Email[input[1]] = input[2];
                    }
                }

                 if (input[0].ToLower() == "Sent") 
                 {
                    if (!Email.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {input[2]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exists.");
                    }


                 }
                input = Console.ReadLine().Split();
            }
            
        }
    }
}
