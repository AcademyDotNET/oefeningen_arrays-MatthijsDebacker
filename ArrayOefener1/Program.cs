using System;

namespace ArrayOefener1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = AskForInt("Please give a number");
            }

            Console.WriteLine($"Sum of all numbers: {Sum(arr)}.");
            Console.WriteLine($"Average of all numbers: {Average(arr)}.");
            Console.WriteLine($"Largest number: {Largest(arr)}.");

            int number = AskForInt("Please give one more number: ");
            string sLarger = "";

            for (int i = 0; i < arr.Length; i++)
            {
               if(arr[i] > number)
                {
                    sLarger += $"{arr[i]} ";
                }
            }

            if(sLarger == "")
            {
                Console.WriteLine("No larger numbers where found.");
            }
            else
            {
                Console.WriteLine("All numbers that are larger: " + sLarger);
            }
        }

        static double Average(int[] arr)
        {
            return  (double)Sum(arr) / arr.Length;
        }

        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int Largest(int[] arr)
        {
            int largest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > largest)
                {
                    largest = arr[i];
                }
            }

            return largest;
        }

        static int AskForInt(string question)
        {
            Console.WriteLine(question);
            int input = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out input))
            {
                Console.Clear();
                Console.WriteLine("Invalid number, please try again");
                sInput = Console.ReadLine();
            }

            return input;
        }
    }
}
