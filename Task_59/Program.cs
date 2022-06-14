// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и 
//столбец, на
// пересечении которых расположен наименьший 
// элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[,] GetCutedArray(int[,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int[,] tempArray = new int[a - 1, b - 1];
    int min = array[0, 0];
    int minPosi = 0;
    int minPosj = 0;
    int movi = 0;
    int movj = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minPosi = i;
                minPosj = j;
            }
        }

    }
    for (int i = 0; i < a - 1; i++)
    {
        for (int j = 0; j < b - 1; j++)
        {
            if (i < minPosi) movi = 0;
            else movi = 1;

            if (j < minPosj) movj = 0;
            else movj = 1;

            tempArray[i, j] = array[i + movi, j + movj];

            // _________на групповых решениях была идея поделить по зонам выполнение условий, метод так и нереализован

        
        }
    }

    //Console.WriteLine($"{min} i = {minPosi} j = {minPosj}");
    return tempArray;
}

void PrintMinLines (int [,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int min = array[0, 0];
    int minPosi = 0;
    int minPosj = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minPosi = i;
                minPosj = j;
            }
        }
    }
    
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (i == minPosi || j == minPosj) Console.Write($"|{array[i,j]}|");
            else Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();

    }
}


int m = 4;
int n = 4;
int[,] arr = GetArray(m, n);
PrintArray(arr);
Console.WriteLine();



PrintMinLines(arr);
Console.WriteLine();
int[,] arrCuted = GetCutedArray(arr);
PrintArray(arrCuted);

