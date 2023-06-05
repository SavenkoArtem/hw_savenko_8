// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 9);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

int FindRowWithMin(int[,] array)
{
    int[] sum_rows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum_rows[i] += array[i,j];
        }
    }
    

    foreach (var item in sum_rows)
    {
        System.Console.WriteLine($"{item, 3}");
    }

    int min = sum_rows[0];
    int min_index = 0;

    for (int i = 1; i < sum_rows.Length; i++)
    {        
            if (min > sum_rows[i])
            {
                min = sum_rows[i];
                min_index = i;
            }    
    }
    
    return min_index;
}

int rows = Promt("Enter rows: ");
int col = Promt("Enter columns: ");
int[,] arrayOne = new int[rows, col];
FillArray(arrayOne);
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"{FindRowWithMin(arrayOne)} row");

