// Задача 53: Задайте двумерный массив. 
//Напишите программу,
// которая поменяет местами 
// первую и последнюю строку
// массива.


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
}

int m = 4;
int n = 5;
int[,] arr = GetArray(m, n);
PrintArray(arr);
Console.WriteLine();

int[,] GetArrayFlipFstLst(int[,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int[,] tempArray = new int[a, b];
    for (int i = 0; i < a; i++)
    {   
        for (int j = 0; j < b; j++)
        {
            if (i==0) tempArray[i,j] = array[a-1, j];
            else if (i==a-1) tempArray[i,j] = array[0, j];
            else tempArray[i,j] = array[i,j];
        }
    }
    return tempArray;
}

int[,] arrFlip = GetArrayFlipFstLst(arr);
PrintArray(arrFlip);
