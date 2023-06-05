// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowsEl(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i, k] < array[i, k + 1])
                {               
                    (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]);
                }                
            }            
        }
    }
}

int rows = Promt("Enter rows: ");
int col = Promt("Enter columns: ");
int[,] arrayOne = new int[rows, col];
FillArray(arrayOne);
PrintArray(arrayOne);
Console.WriteLine();
SortRowsEl(arrayOne);
PrintArray(arrayOne);