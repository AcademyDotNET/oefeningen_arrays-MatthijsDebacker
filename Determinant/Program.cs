using System;

namespace Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = {
            {2, 4 },
            {3, 5 }
            };

            int[,] matrix2 = {
            {2, 4, 5 },
            {3, 5, 3 },
            {1, 0, 3 }
            };

            Console.WriteLine($"Determinant of the 2x2 matrix is: {CalculateDeterminant(matrix1)}");
            Console.WriteLine($"Determinant of the 3x3 matrix is: {CalculateDeterminant(matrix2)}");
        }

        static int CalculateDeterminant(int[,] matrix)
        {
            int determinant = 0;

            if(matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) 
            {
                determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            }
            else if(matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
            {
                int a = (matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]);
                int b = (matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]);
                int c = (matrix[1, 0] * matrix[2, 1]) - (matrix[2, 0] * matrix[1, 1]);

                determinant = matrix[0,0] * a - matrix[0,1] * b + matrix[0,2] * c;
            }

            return determinant;   
        }
    }
}
