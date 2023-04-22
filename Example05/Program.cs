// Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= m * n)
    {
        array[i, j] = number;
        if (i <= j + 1 && i + j < n - 1)
            ++j;
        else if (i < j && i + j >= m - 1)
            ++i;
        else if (i >= j && i + j > n - 1)
            --j;
        else
            --i;
        number++;
    }
    return array;
}

void PrintArray(int[,] matr)
{
int i,j;
for (i = 0; i < matr.GetLength(0); i++)
{
Console.WriteLine();
for (j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i,j]} ");
}
}
}

Console.Write("Enter rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array =  FillArray(m, n);
Console.WriteLine($"Массив: ");
PrintArray(array);

