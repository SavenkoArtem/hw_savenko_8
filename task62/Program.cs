// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}


void FillArray(string[,] array)
{    
    int st_x = 1;
    int st_y = 0;
    int change_st = 0;
    int count_col = array.GetLength(1);
    int row = 0;
    int col = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i < 9)
            array[row, col] = "0" + Convert.ToString(i + 1);
        else
            array[row, col] = Convert.ToString(i + 1);

        if ((count_col = count_col - 1) == 0)
        {
            count_col = array.GetLength(1) * (change_st % 2) + array.GetLength(1) * ((change_st + 1) % 2) - (change_st / 2 - 1) - 2;
            int temp = st_x;
            st_x = -st_y;
            st_y = temp;
            change_st++;
        }

        col += st_x;
        row += st_y;
    }
}



int rows = Promt("Enter first matrix's rows: ");
int col = Promt("Enter first matrix's  col: ");
string[,] array = new string[rows, col];
FillArray(array);
PrintArray(array);