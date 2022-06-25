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
    int[] arrayFull = new int[a * b];
    int countFull = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            if (countFull < a * b)
            {
                arrayFull[countFull] = array[i, j];
                //Console.Write($"{arrayFull[countFull]} "); // для проверки строчного вывода
                countFull++;
            }
        }
    }

    
    for (int i = 0; i < arrayFull.Length; i++) // сортировка по возрастания для красоты
    {  
        int temp = arrayFull[0];
        for (int j = 0; j < arrayFull.Length - 1 - i; j++)
        {
            if (arrayFull[j] > arrayFull[j + 1])
            {
                temp = arrayFull[j];
                arrayFull[j]= arrayFull[j + 1];
                arrayFull[j + 1] = temp;
            }
        }
    }



    for (int i = 0; i < a * b; i++)
    {
        int count = 0;
        int flag = 0;

        for (int j = 0; j < a * b; j++)
        {
            if (arrayFull[i] == arrayFull[j]) count++;
        }

        for (int k = 0; k < i; k++)
        {
            if (arrayFull[i] == arrayFull[k]) flag++;
        }

        if (flag == 0)
        {
            if (count > 11 && count < 15)
            { Console.WriteLine($"{arrayFull[i]} повторяется {count} раз"); }

            else if (
                (count % 10 > 1) && (count % 10 < 5)
                )
            {
                Console.WriteLine($"{arrayFull[i]} повторяется {count} раза");
            }

            else Console.WriteLine($"{arrayFull[i]} повторяется {count} раз");
        }

    }
    Console.WriteLine();
}


int m = 10;
int n = 20;
int[,] arr = GetArray(m, n);


PrintArray(arr);
FindElemRepeat(arr);

