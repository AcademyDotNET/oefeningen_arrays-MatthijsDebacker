using System;

namespace GroteSom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1 + 3 + 5 + 10 = {Sum(1, 3, 5, 10)}");

            Random rand = new Random();
            int[] arr = new int[50];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 101);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum = {Sum(arr)}");
        }

        static int Sum(params int[] arr)
        {
            int sum = 0;

            foreach (var i in arr)
            {
                sum += i;
            }

            return sum;
        }
    }
}
