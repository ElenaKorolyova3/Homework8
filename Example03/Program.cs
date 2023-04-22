// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
            Console.Write($"{matr[i, j]} ");
    }
            Console.WriteLine();
    }
}


void FillArray(int[,] matr, int min, int max)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(min, max+1);
    }
    }
}

int[,] CompositionArray(int[,] array, int[,] array1)
{
    var array2 = new int[array.GetLength(0), array1.GetLength(1)];

        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array2[i, j] += array[i, k] * array1[k, j];
                }
            }
        }
    return array2;
}


int[,] array = new int[2,2];
int[,] array1 = new int[2,2];
FillArray(array,1,9);
FillArray(array1,1,9);
PrintArray(array);
Console.WriteLine("- -");
PrintArray(array1);
int[,] array2 = CompositionArray(array, array1);
Console.WriteLine("Произведение двух матриц равно:");
PrintArray(array2);