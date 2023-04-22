// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumElements(int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[index]+= matr[i,j];
        }
        index++;
    }
    return sum;
}

void MinSumElements (int[] matr)
{
    int minSum = matr[0];
    int index = 0;
    for (int i = 0; i < matr.Length; i++)
      if (matr[i] < minSum)
        {
            minSum = matr[i];
            index = i;
        }
    Console.WriteLine ($"Наименьшая сумма элементов в строке № {index+1}");
}

int[,] array = new int[4,5];
FillArray(array,0,9);
PrintArray(array);
int[] sumArray = SumElements(array);
MinSumElements(sumArray);

