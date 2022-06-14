// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод
// в виде равнобедренного треугольника

Console.WriteLine("Введите N строк для треугольника Паскаля");
int num = int.Parse(Console.ReadLine());

void PrintPascalTriangle(int nRow)
{
    int n = nRow + 1;

    int[,] array = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        string emptStr = String.Concat(Enumerable.Repeat("   ", n - i));
        Console.Write(emptStr);

        for (int j = 0; j <= i; j++)
        {
            if (i == 0 || j == 0 || i == j || i == 1)
            {

                array[i, j] = 1;
                Console.Write($"{array[i, j],6}");
            }
            else
            {
                array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
                Console.Write($"{array[i, j],6}");
            }
        }
        Console.WriteLine();
    }
}

PrintPascalTriangle(num);

