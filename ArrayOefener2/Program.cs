using System;

namespace ArrayOefener2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[5];

            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = AskForInt("List 1) Please give a number");
            }
            Console.WriteLine();

            int[] arrB = new int[5];

            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = AskForInt("List 2) Please give a number");
            }
            Console.WriteLine();

            Console.WriteLine("The sum of the elements of both arrays are: ");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.WriteLine($"{arrA[i] + arrB[i]}");
            }
        }

        static int AskForInt(string question)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                Console.WriteLine("Invalid number, please try again");
                sInput = Console.ReadLine();
            }

            return input;
        }
    }
}
