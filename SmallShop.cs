﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.80 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.20 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.60 * quantity);
                }
            }
            if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.30 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.50 * quantity);
                }
            }
            if (town == "varna")
            {
                if (product == "coffee") Console.WriteLine(0.45*quantity);
                if (product == "water") Console.WriteLine(0.70*quantity);
                if (product == "beer") Console.WriteLine(1.10*quantity);
                if (product == "sweets") Console.WriteLine(1.35*quantity);
                if (product == "peanuts") Console.WriteLine(1.55*quantity);
            }
        }
    }
}
