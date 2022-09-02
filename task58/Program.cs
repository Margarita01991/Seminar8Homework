// /* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18 */

Console.Clear();
int[,] FillMatrixRandom(int rows, int columns, int leftRange = 1, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}
void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
}

const int SIZE = 2;
int [,] matrixA = FillMatrixRandom(SIZE, SIZE);
int [,] matrixB = FillMatrixRandom(SIZE, SIZE);

int[,] matrixProduct = new int[SIZE, SIZE];

for (int i = 0; i < SIZE; i++)
{
    for (int j = 0; j < SIZE; j++)
    {
        for (int k = 0; k < SIZE; k++)
        {
            matrixProduct[i, j] = matrixProduct[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица А");
PrintMatrix(matrixA);
Console.WriteLine("Матрица В");
PrintMatrix(matrixB);
Console.WriteLine("Произведение матриц");
PrintMatrix(matrixProduct);