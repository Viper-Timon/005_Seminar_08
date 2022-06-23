// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


int[,,] Get3dRndArray(int a, int b, int c) // справедливо при (a*b*c) < 90
{
    вав // для подсветки
    if (a * b * c < 90)
    {
        int[,,] array = new int[a, b, c];
        Random rndNum = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = rndNum.Next(10, 100);
                    foreach (int l in array)
                    {
                        Console.Write($"{l} {array[i, j, k]} | ");
                        if (l == array[i, j, k])
                        {
                            array[i, j, k] = rndNum.Next(10, 100);
                            Console.WriteLine(array[i, j, k]);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        Console.WriteLine();
        return array;
    }
    else
    {
        int[,,] array = new int[0, 0, 0];
        return array;
    }
}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"{i + 1}-й уровень");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {j + 1}-я строка -> ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],2} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void Print3dbyForeach(int[,,] array)
{

    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
int a = 3;
int b = 3;
int c = 3;

int[,,] arr = Get3dRndArray(a, b, c);
Print3dArray(arr);
Print3dbyForeach(arr);

