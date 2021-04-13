using System;

namespace _2DArrayViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOne = { 
                { 15, 6, 9 },
                { 1, 8, 5 }
            };
            int[,] arrayTwo = {
                { 0, 1, 2, 3, 4, 5, 6 },
                { 6, 5, 4, 3, 2, 1, 0}
            };

            VisualiseArray(arrayOne);
            Console.WriteLine();
            VisualiseArray(arrayTwo);
        }

        static void VisualiseArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j], 3}");
                }
                Console.WriteLine();
            }
        }
    }
}
