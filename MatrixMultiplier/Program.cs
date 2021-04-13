using System;

namespace MatrixMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayOne = {
                { 15, 6 },
                { 1, 8 }
            };
            int[,] arrayTwo = {
                { 0, 1, 2},
                { 6, 5, 4}
            };

            var mat = VermenigvuldigMatrix(arrayOne, arrayTwo);
            if(mat != null)
            {
                VisualiseArray(mat);
            }
        }

        static int[,] VermenigvuldigMatrix(int[,] arr1, int[,] arr2)
        {
            if(arr1.GetLength(1) != arr2.GetLength(0))
            {
                Console.WriteLine("Cannot multiply matrices, invalid dimensions.");
                return null;
            }

            int[,] result = new int[arr1.GetLength(0),arr2.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    int dot = 0;
                    for (int l = 0; l < arr2.GetLength(0); l++)
                    {
                        dot += arr1[i, l] * arr2[l, j];
                    }
                    result[i, j] = dot;
                }
            }

            return result;
        }

        static void VisualiseArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],8}");
                }
                Console.WriteLine();
            }
        }
    }
}
