using System;

namespace ArrayViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 15, 6, 9 };
            int[] arrayTwo = { 0, 1, 2, 3, 4, 5, 6 };

            VisualiseArray(arrayOne);
            VisualiseArray(arrayTwo);
        }

        static void VisualiseArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
