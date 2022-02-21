using System;
using System.Collections.Generic;

namespace Ukazatel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nomera = new Dictionary<string, string>();

            while(true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "Exit")
                {



                    foreach (var p in nomera)
                    {
                        Console.WriteLine($"{p.Key}->{p.Value}");
                    }
                    break;
                }

                    string ime = input[0];
                    string nomer = input[1];

                    if (!nomera.ContainsKey(ime))
                    {
                        nomera.Add(ime, nomer);
                    }
                    else
                    {
                    nomera[ime] = nomer;
                    }

                }
            }
        }
    }

