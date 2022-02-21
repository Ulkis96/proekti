using System;
using System.Collections.Generic;

namespace DictionaryLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionaryclass = new Dictionary<int, string>();

            dictionaryclass.Add(14, "Maria");
            dictionaryclass.Add(15, "martin");
            dictionaryclass.Add(16, "martinPetrov");
            dictionaryclass.Add(17, "martin Stoyanov");
            


            if(!dictionaryclass.ContainsKey(17))
            {
                dictionaryclass.Add(17, "Mira");
            }
            else
            {
                dictionaryclass[17] = "Mira";
            }

            foreach (var student in dictionaryclass)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");

            }

        }
    }
}
