﻿using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberCPU = int.Parse(Console.ReadLine());
            int numberRAM = int.Parse(Console.ReadLine());

            double vCardsPrice = numberVideoCards * 250;

            double sumCPU = vCardsPrice * 0.35 * numberCPU;

            double sumRAM = vCardsPrice * 0.1 * numberRAM;

            double bill = vCardsPrice + sumCPU + sumRAM;

            if (numberVideoCards > numberCPU)
            {
                bill *= 0.85;
            }

            if (bill <= budget)
            {
                Console.WriteLine($"You have {(budget - bill):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(bill - budget):F2} leva more!");
            }

        }
    }
}
