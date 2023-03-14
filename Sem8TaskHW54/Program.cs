//Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// //метод чтения данных пользователя
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

//метод генерации 2D массива
int[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)

{
    //Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    int[,] arr = new int[countRow, countColumn];


    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}
//метод печати 2D массива
void Print2DArr(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine(string.Empty);
    }
}

//метод обмена элеметнтов
void Swap(ref int e1, ref int e2) //используем ссылочный тип данных для универсальности метода
{
    int temp = e1;
    e1 = e2;
    e2 = temp;
}

//метод сортировки пузырьком
void BubleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++) //j начинает со 2 числа массива, т.к сравнивать 1 и тоже число бессмысленно
        {
            if (arr[i] > arr[j])
            {
                Swap(ref arr[j], ref arr[i]);
            }
        }
    }
}

//метод сортировки массива по строчно
void Change2DArr(int[,] arr)
{
    int[] row = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < row.Length; j++)
        {
            row[j] = arr[i, j];
        }
        BubleSort(row);
        for (int j = 0; j < row.Length; j++)
        {
            arr[i, j] = row[j];
        }
    }
}

int[,] test2Darr = Gen2DArr(5, 5, 1, 10);
Print2DArr(test2Darr);
Console.WriteLine(string.Empty);
Change2DArr(test2Darr);
Print2DArr(test2Darr);