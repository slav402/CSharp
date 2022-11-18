﻿using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (city == "Sofia")
            {
                switch (produkt)
                {
                    case "coffee":   price = 0.5;    break;
                    case "water":   price = 0.8;    break;
                    case "beer":    price = 1.2;    break;
                    case "sweets":   price = 1.45;    break;
                    case "peanuts": price = 1.6;    break;
                    default:
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (produkt)
                {
                    case "coffee":   price = 0.4; break;
                    case "water":   price = 0.7; break;
                    case "beer":    price = 1.15; break;
                    case "sweets":   price = 1.3; break;
                    case "peanuts": price = 1.5; break;
                    default:
                        break;
                }
            }
            else
            {
                switch (produkt)
                {
                    case "coffee":   price = 0.45; break;
                    case "water":   price = 0.7; break;
                    case "beer":    price = 1.1; break;
                    case "sweets":   price = 1.35; break;
                    case "peanuts": price = 1.55; break;
                    default:
                        break;
                }
            }

            Console.WriteLine((count * price));
        }
    }
}
