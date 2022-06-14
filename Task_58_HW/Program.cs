// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет
// находить произведение двух матриц.


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
            Console.Write($"{array[i, j], 2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetMultArray(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) == array2.GetLength(0)
        && array1.GetLength(1) == array2.GetLength(1))
        {
        int a = array1.GetLength(0);
        int b = array1.GetLength(1);
        int[,] arrayMult = new int [a, b];

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                arrayMult[i,j] = array1[i, j] * array2[i, j];
            }
        }
        return arrayMult;
        }
    else 
    {
        Console.WriteLine("Размеры массивов не совпадают");
        int [,] arrayMult = new int [0,0]; // при печати массива будет выводиться пустя строчка
        return arrayMult;
    }    
}

int m = 4;
int n = 5;
int[,] arr1 = GetArray(m, n);
int[,] arr2 = GetArray(m, n);

PrintArray(arr1);
PrintArray(arr2);

int[,] arrMult = GetMultArray(arr1, arr2);
PrintArray(arrMult);



