using System;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            string dnaOne = "";
            string dnaTwo = "two";
            while (dnaOne.Length != dnaTwo.Length)
            {
                Console.Clear();
                dnaOne = AskForDNAString();
                dnaTwo = AskForDNAString();
            }

            int distance = 0;
            for (int i = 0; i < dnaOne.Length; i++)
            {
                if (dnaOne[i] != dnaTwo[i])
                {
                    distance++;
                }
            }

            Console.WriteLine($"The hamming distance of these two DNA strings is: {distance}.");
        }

        static string AskForDNAString()
        {
            Console.WriteLine("Please give a valid DNA string. (G A C T)");
            return Console.ReadLine();
        }
    }
}
