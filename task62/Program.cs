/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.Clear();
const int SIZE = 4;
int[,] matrix = new int[SIZE, SIZE];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SIZE * SIZE)
{
    matrix[i, j] = temp;
    if (i <= j + 1 && i + j < SIZE - 1)
        j++;
    else if (i < j && i + j >= SIZE - 1)
        i++;
    else if (i >= j && i + j > SIZE - 1)
        j--;
    else
        i--;
    temp++;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}
PrintMatrix(matrix);