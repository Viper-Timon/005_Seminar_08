// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


int[,,] Get3dRndArray(int a, int b, int c) // справедливо при (a*b*c) <= 90
{

    if (a * b * c <= 90 && a * b * c > 0)
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
                }

            }
        }

        //развертывание 3d в линейный массив
        int[] arrayFull = new int[a * b * c];
        int countFull = 0;
        foreach (int elem in array)
        {
            arrayFull[countFull] = elem;
            countFull++;
        }

        // arrayFull[0] = 45; // для проверки
        // arrayFull[1] = 45; // для проверки
        // arrayFull[2] = 45; // для проверки

        // проверка на уникальность и присвоение нового случайного
        for (int i = 0; i < a * b * c; i++)
        {
            int flag = 0;

            for (int j = 0; j < i; j++)
            {
                if (arrayFull[i] == arrayFull[j]) flag++;
            }

            if (flag != 0)
            {
                arrayFull[i] = rndNum.Next(10, 100);
                i--;
            }

        }

        // Заполнение 3d массива значениями линейного
        int indexNewFill = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = arrayFull[indexNewFill];
                    indexNewFill++;
                }

            }
        }


        Console.WriteLine();
        return array;
    }
    else
    {
        Console.WriteLine("Невозможно построить 3d массив с уникальными элеентами такого размера");
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

int a = 3;
int b = 3;
int c = 10;

int[,,] arr = Get3dRndArray(a, b, c);
Print3dArray(arr);



