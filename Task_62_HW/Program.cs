// Задача 62: Заполните спирально массив 4 на 4.
// Доп. задача 1.

// некорректное решение // подсветка

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

int[,] FillSpiralArray(int[,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int countElem = 1;
    int indexi = 0;
    int indexj = 0;
    int limiter = 0;
    int countTimesRound = a > b ? b : a; // поиск минимальной из длин массива для счетчика оборотов



    for (int countRound = 0; countRound <= countTimesRound / 2; countRound++) // цикл оборотов
    {
        for (int j = indexj; j < b; j++)
        {
            int i = indexi;
            if (array[i, j] == 0)
            {
                array[i, j] = countElem;
                countElem++;
                indexj = j;
            }
        }

        for (int i = indexi; i < a; i++)
        {
            int j = indexj;
            if (array[i, j] == 0)
            {
                array[i, j] = countElem;
                countElem++;
                indexi = i;
            }
        }

        for (int j = indexj; j >= limiter; j--)
        {
            int i = indexi;
            if (array[i, j] == 0)
            {
                array[i, j] = countElem;
                countElem++;
                indexj = j;
            }
        }

        for (int i = indexi; i >= limiter; i--)
        {
            int j = indexj;
            if (array[i, j] == 0)
            {
                array[i, j] = countElem;
                countElem++;
                indexi = i;
            }
        }

        indexi = countRound + 1;
        indexj = countRound + 1;
        a--;
        b--;
        limiter++;
    }

    return array;

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int m = 8;
int n = 3;
int[,] arr = GetArray(m, n);

arr = FillSpiralArray(arr);
PrintArray(arr);

