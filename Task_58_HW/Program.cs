// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет
// находить произведение двух матриц.

// Инфо:
// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K. 
// Матрицы, для которых данное условие не выполняется, умножать нельзя.


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
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetMultArray(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int a = array1.GetLength(0);
        int b = array2.GetLength(1);
        int c = array1.GetLength(1);
        int[,] arrayMult = new int[a, b];

        for (int k = 0; k < c; k++)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arrayMult[i, j] += array1[i, k] * array2[k, j];
                    //Console.WriteLine($"i={i} k={k} k={k} j={j}"); //проверка значений
                }
            }
        }
        return arrayMult;

    }
    else
    {
        Console.WriteLine("Кол-во столбцов 1го массива не совпадает с количество строк 2го");
        int[,] arrayMult = new int[0, 0]; // при печати массива будет выводиться пустя строчка
        return arrayMult;
    }
}

int m1 = 2;
int n1 = 4;
int m2 = 4;
int n2 = 6;
int[,] arr1 = GetArray(m1, n1);
int[,] arr2 = GetArray(m2, n2);

PrintArray(arr1);
PrintArray(arr2);

int[,] arrMult = GetMultArray(arr1, arr2);
PrintArray(arrMult);

