
using System;

class Program
{
    static void Main()
    {
        int rows = 4;
        int columns = 4;

        int[,] cyclicMatrix = CreateCyclicMatrix(rows, columns);

        // Print the cyclic matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(cyclicMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] CreateCyclicMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        int value = 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = value++;
            }
            // Shift the last element to the front
            int temp = matrix[i, columns - 1];
            for (int k = columns - 1; k > 0; k--)
            {
                matrix[i, k] = matrix[i, k - 1];
            }
            matrix[i, 0] = temp;
        }

        return matrix;
    }
}


