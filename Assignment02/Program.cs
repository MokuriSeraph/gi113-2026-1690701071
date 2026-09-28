/*
 * Student ID : 1690701071
 * Name       : Peraphat Sungwan
 * Section    : 129A
 * No.        : 37
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("=====----- Welcome to Topaz's little Forge Shop -----=====");
            Console.WriteLine("----------------------------------------------------------");

            const double SmeltRate = 0.5;
            const double SalvageRate = 0.7;
            const string OreName = "Adamantite";
            const int MaxBatch = 500;

            Console.WriteLine("Smelting Rate => 0.5 (Ore -> Ingot)");
            Console.WriteLine("Salvaging Rate => 0.25 (Ingot -> Ore)");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Input S for Smelting");
            Console.WriteLine("Input B for Breakdown");
            Console.Write("Enter S/B : ");
            char.TryParse(Console.ReadLine(), out char choice);
            Console.Write("How many : ");
            double.TryParse(Console.ReadLine(), out double amount);

            if (amount > 0 && amount <= MaxBatch)
            {
                if (choice == 's' || choice == 'S')
                {
                    double totalIngot = amount * SmeltRate;
                    Console.WriteLine($"You have smelted {amount} of {OreName} ore(s) and gain {totalIngot:F2} ingot(s)");
                }
                else if (choice == 'b' || choice == 'B')
                {
                    double totalOre = amount / SalvageRate;
                    Console.WriteLine($"You have salvaged {amount} of {OreName} ingot(s) and gain {totalOre:F2} ore(s)");
                }
                else
                {
                    Console.WriteLine("Please enter S or B in the input.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid amount (Max 500)");
            }

        }
    }
}
