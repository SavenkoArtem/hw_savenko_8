// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool isValidate(int[,] arrayOne, int[,] arrayTwo)
{
    bool flag = false;

    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
    {
        flag = true;
    }
    
    return flag;
}

int[,] MatrixMultiplication(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayMultip = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

    for (int i = 0; i < arrayMultip.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultip.GetLength(1); j++)
        {
            for (int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                arrayMultip[i, j] += arrayOne[i,k] * arrayTwo[k,j];
            }            
        }
    }

    return arrayMultip;
}



int rows_first = Promt("Enter first matrix's rows: ");
int col_first = Promt("Enter first matrix's  columns: ");
int rows_second = Promt("Enter second matrix's rows: ");
int col_second = Promt("Enter second matrix's columns: ");
int[,] arrayOne = new int[rows_first, col_first];
int[,] arrayTwo = new int[rows_second, col_second];
FillArray(arrayOne);
PrintArray(arrayOne);
Console.WriteLine();
FillArray(arrayTwo);
PrintArray(arrayTwo);
Console.WriteLine();

if (isValidate(arrayOne, arrayTwo))
{
    int[,] arrayMultip = MatrixMultiplication(arrayOne, arrayTwo);    
    PrintArray(arrayMultip);
}