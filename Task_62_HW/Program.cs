// Задача 62: Заполните спирально массив 4 на 4.
// Доп. задача 1.

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}

int[,] GetArrayMask(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) + 2, array.GetLength(0) + 2];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (i == 0
            || j == 0
            || i == newArray.GetLength(0) - 1
            || j == newArray.GetLength(1) - 1)
                newArray[i, j] = 0;

            else newArray[i, j] = 1;
        }
    }
    return newArray;
}

int[,] FillSpiralArray(int[,] array, int i, int j)
{

    if  (
        array[i, j] == 0
        && j < array.GetLength(1)
        && i < array.GetLength(0)
        )
    {
        array[i, j] = 3;

        FillSpiralArray(array, i, j + 1);
        FillSpiralArray(array, i + 1, j);
        FillSpiralArray(array, i, j - 1);
        FillSpiralArray(array, i - 1, j);

        return array;
    }
    else
    {
        return array;
    }


}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int m = 4;
int n = 4;
int[,] arr = GetArray(m, n);
PrintArray(arr);
// arr = GetArrayMask(arr);
// PrintArray(arr);
arr = FillSpiralArray(arr, 0, 0);
PrintArray(arr);
//arr = FillSpiralArray(arr, 0, 0);
//PrintArray(arr);




