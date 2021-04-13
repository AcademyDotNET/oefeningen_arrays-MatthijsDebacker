using System;

namespace ArrayZoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = AskForInt("Please give a number.");
            }

            int number = AskForInt("Please give a number to remove from the list: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == number)
                {
                    // Shift all to the left
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    // Put the last number to -1 if it isn't already
                    if(arr[arr.Length - 1] != -1)
                    {
                        arr[arr.Length - 1] = -1;
                    }

                    // Set index back by one to check repeated occurences
                    i--;
                }
            }

            Console.WriteLine();
            Console.WriteLine("The list is now: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
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
