// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //2
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2- 3
        }
    }
    return matrix;
}

int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //2
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2- 3
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] ProductOfMatrices(int[,] array2D, int[,]array)
{
int[,] resArray = new int[2, 2];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resArray[i, j] = 0;
            for (int k = 0; k < array2D.GetLength(1); k++)
            {
                resArray[i, j] += array2D[i, k] * array[k, j];
            }
        }
    }
    return resArray;
}

int[,] array2D = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(array2D);
Console.WriteLine();
int[,] array = CreateMatrixRndInt1(2, 2, 1, 5);
PrintMatrix(array);
Console.WriteLine();
int[,] productOfMatrices = ProductOfMatrices(array2D, array);
PrintMatrix(productOfMatrices);