// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArray(int[,,] array)
{
    int[] check_unique = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int index_check = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int temp = new Random().Next(10, 99);
                while (isNotUnique(check_unique, temp) == true)
                {
                    temp = new Random().Next(10, 99);
                }
                array[i,j,k] = temp;
                check_unique[index_check] = temp;
                index_check += 1;
            }

}

bool isNotUnique(int[] array, int temp)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (temp == array[i])
            flag = true;        
    }
    return flag;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {     
            System.Console.Write(" | ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) | ");
            }
            System.Console.WriteLine();
        }        
    }
}



int x = Promt("Enter first matrix's x: ");
int y = Promt("Enter first matrix's y: ");
int z = Promt("Enter second matrix's z: ");
int[,,] array = new int[x, y, z];
System.Console.WriteLine();
FillArray(array);
PrintArray(array);
