using System;

namespace LeveringsBedrijf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] postCodes = new int[10] { 3000, 3001, 3010, 3012, 3018, 3020, 3040, 3050, 3060, 3080 };
            double[] prices = new double[10] { 15.5, 20.2, 18.5, 16.3, 14.0, 20.1, 19.5, 22.2, 16.3, 15.5};

            double weight = AskForDouble("Give the weight of the package.");
            int postCode = AskForInt("To which postcode do you wish to send the packge?");

            bool found = false;
            for (int i = 0; i < postCodes.Length; i++)
            {
                if(postCode == postCodes[i])
                {
                    Console.WriteLine($"This will cost {(weight * prices[i]):F2} Euros.");
                    found = true;
                }
                else if(i == postCodes.Length - 1 && !found)
                {
                    Console.WriteLine("This company does not deliver to that area.");
                }
            }

        }

        static int AskForInt(string question, string errorResponse = "Invalid number, please try again", bool clear = false)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                if(clear)
                {
                    Console.Clear();
                }
                Console.WriteLine(errorResponse);
                sInput = Console.ReadLine();
            }

            return input;
        }

        static double AskForDouble(string question, string errorResponse = "Invalid number, please try again", bool clear = false)
        {
            Console.WriteLine(question);
            double input = 0;

            string sInput = Console.ReadLine();
            while (!double.TryParse(sInput, out input))
            {
                if(clear)
                {
                    Console.Clear();
                }
                Console.WriteLine(errorResponse);
                sInput = Console.ReadLine();
            }

            return input;
        }

    }
}
