using System;

namespace Opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(FillArrayZeroToTen());
            PrintArray(FillArrayHundredToZero());
            PrintArray(FillArrayAToZ());
            PrintArray(FillArrayWithRandom());
            PrintArray(FillArrayWithAlternatingBool());
        }

        static int[] FillArrayZeroToTen()
        {
            int[] arr = new int[11];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            return arr;
        }

        static int[] FillArrayHundredToZero()
        {
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 100 - i; 
            }

            return arr;
        }

        static char[] FillArrayAToZ()
        {
            char[] arr = new char[26];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar((i + 97));
            }

            return arr;
        }

        static int[] FillArrayWithRandom()
        {
            int[] arr = new int[20];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 101);
            }

            return arr;
        }

        static bool[] FillArrayWithAlternatingBool()
        {
            bool[] arr = new bool[30];

            for (int i = 0; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    arr[i] = true;
                }
                else
                {
                    arr[i] = false;
                }
            }

            return arr;
        }

        static void PrintArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
                if(i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
