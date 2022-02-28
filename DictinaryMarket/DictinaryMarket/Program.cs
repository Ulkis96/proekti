using System;
using System.Collections.Generic;

namespace DictinaryMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> DictionaryPrice = new Dictionary<string, double>();
            Dictionary<string, int> DictionaryCount = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "stocked")
                    break;

                string ProductName = input[0];
                double Price = double.Parse(input[1]);
                int Count = int.Parse(input[2]);

                if (!DictionaryPrice.ContainsKey(ProductName))
                {
                    DictionaryPrice.Add(ProductName, Price);
                    DictionaryCount.Add(ProductName, Count);
                }
                else
                {
                    DictionaryPrice[ProductName] = Price;
                    DictionaryCount[ProductName] += Count;
                }


            }

            double grandtotal = 00.00;
            foreach (var product in DictionaryPrice)
            {
                string ProductName = product.Key;
                double Price = product.Value;
                int count = DictionaryCount[ProductName];
                Console.WriteLine($"{Price:f2} * {count} = ${Price*count:f2} ");
                grandtotal += Price * count;
            }
            Console.WriteLine($"GrandTotal: ${grandtotal:f2}");
        }
    }
}
