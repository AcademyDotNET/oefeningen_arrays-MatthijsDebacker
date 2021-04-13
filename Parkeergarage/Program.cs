using System;

namespace Parkeergarage
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrOfCars = AskForInt("Please give the number of cars: ");
            int[] durations = new int[nrOfCars];
            double[] costs = new double[nrOfCars];
            
            for (int i = 0; i < nrOfCars; i++)
            {
                durations[i] = AskForInt($"Please give the parking time for car {i + 1} in hours: ");
                costs[i] = CalculateCosts(durations[i]);
            }

            Console.Clear();
            PrintTable(durations, costs);
        }

        static int AskForInt(string question, string errorResponse = "Invalid number, please try again", bool clear = false)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                if (clear)
                {
                    Console.Clear();
                }
                Console.WriteLine(errorResponse);
                sInput = Console.ReadLine();
            }

            return input;
        }

        static double CalculateCosts(int duration)
        {
            if(duration == 0)
            {
                return 0.0;
            }
            else if (duration <= 3)
            {
                return 2.0;
            }
            else if (duration >= 24)
            {
                return 10.0;
            }

            double costs = 2.0;
            for (int i = 1; i <= duration - 3; i++)
            {
                costs += 0.5;
            }

            return costs;
        }

        static void PrintTable(int[] durations, double[]costs)
        {
            Console.WriteLine("Car\tDuration\tCosts\t");

            int sumDurations = 0;
            double sumCosts = 0.0;
            for (int i = 0; i < durations.Length; i++)
            {
                Console.WriteLine($"{i+1}\t{durations[i]}\t{costs[i]}");
                sumDurations += durations[i];
                sumCosts += costs[i];
            }

            Console.WriteLine("Totals: ");
            Console.WriteLine($"{durations.Length}\t{sumDurations}\t{sumCosts}");
        }
    }
}
