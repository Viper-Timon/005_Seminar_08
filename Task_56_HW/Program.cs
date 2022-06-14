// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintMinSumOfRow(int[,] array)
{
    int sumRowMin = 0;
    int minRow = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRowMin += array[0, j];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRowElem = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRowElem += array[i, j];
        }
        if (sumRowElem < sumRowMin)
        {
            sumRowMin = sumRowElem;
            minRow = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов находится на строке № {minRow+1} ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[minRow, j] + " ");
    }
    Console.Write($" = {sumRowMin}");
    

}


int m = 4;
int n = 5;
int[,] arr = GetArray(m, n);

PrintArray(arr);
PrintMinSumOfRow(arr);

Console.WriteLine();

