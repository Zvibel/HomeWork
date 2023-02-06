/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


Console.WriteLine("Задайте количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] InitMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double[,] matrix = InitMatrix(rows, columns);

PrintMatrix(matrix);