using System;

namespace VraagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[6]{
                "What is 2 + 2?",
                "What is that + 6?",
                "What is that devided by 10?",
                "How many times does that fit in 20?",
                "How many times is that larger than 5?",
                "What is that divided by 2?"
            };

            int[] answerArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                answerArr[i] = AskForInt("Your answer: ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
                Console.WriteLine(answerArr[i]);
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
