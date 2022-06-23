// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Доп. задача 2.




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

void FindElemRepeat(int[,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int [] arrayFull = new int [a*b];
    int i = 0;
    foreach (int elem in array)
    {
        arrayFull[i]=elem;
        i++;
        Console.Write($"{arrayFull[i]} ");
    }

    foreach (int elem in array)
    {
       
        int count = 0;
        Console.Write($"{elem} повторяется ");
        foreach (int item in array)
        {
            if (elem == item) count++;
        }
        Console.WriteLine($"{count} раз");
    }
    Console.WriteLine();

}



int m = 3;
int n = 4;
int[,] arr = GetArray(m, n);


PrintArray(arr);
FindElemRepeat(arr);
