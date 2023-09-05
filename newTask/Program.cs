// Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса чётные, и замените эти элементы на их
//квадраты.Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

/*int[,] matrix = new int[,] - не захотели
{
{1, 4, 7, 2}
{5, 9, 2, 3}
{8, 4, 2, 4}
}
*/

using System.Numerics;

int[,] GetMatrix(int rows = 5, int columns = 6)
{

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintOldMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintEvenSqMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];

            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] TrueMatrix = GetMatrix();
PrintOldMatrix(TrueMatrix);
Console.WriteLine();
PrintEvenSqMatrix(TrueMatrix);


