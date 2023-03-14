// Задача №53
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine(string.Empty);
    }
}


//метод смены строк в массиве
void SwapRow2DArr (int[,] arr)
{
    int temp = 0;
    for (int j = 0; j<arr.GetLength(1); j++)
    {
        temp = arr[0,j];
        arr[0,j]=arr[arr.GetLength(0)-1,j];
        arr[arr.GetLength(0)-1,j] = temp;
    }
}

int row = ReadData("Ввеидте количество строк: ");
int column = ReadData("Введите количество столбов: ");
int[,] testArr = Gen2DArr(row,column,1,100);
Print2DArr(testArr);
SwapRow2DArr(testArr);
Console.WriteLine(string.Empty);
Print2DArr(testArr);