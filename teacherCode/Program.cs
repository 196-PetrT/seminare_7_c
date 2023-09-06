// Задача 46: Задайте двумерный массив размером m x n, 
// заполненный случайными целыми числами
// m = 3, n = 4.


int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // метод вывода массива на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SetNumber(string message = " ") // добавим метод для получения чисел вводом с консоли
{
    System.Console.WriteLine($"Enter number {message} : ");
    return Convert.ToInt32(Console.ReadLine());
    // или
    // int num = Convert.ToInt32(Console.ReadLine());
    // return num;
}

int rows1 = SetNumber("rows");
int columns1 = SetNumber("columns");
int maxValue1 = SetNumber("maxValue");
int minValue1 = SetNumber("minValue");

// int [,] matrix = GetMatrix(rows, columns); - чтобы можно было передавать в другом порядке
int [,] matrix = GetMatrix(rows: rows1, columns: columns1);
PrintMatrix(matrix);
