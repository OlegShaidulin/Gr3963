// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя

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

            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine(string.Empty);
    }
}


void TraspArr(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

int n = ReadData("Введите количетсво строк: ");
int m = ReadData("Введите количетсво столбов: ");
int[,] testArr = Gen2DArr(n, m, 1, 20);
Print2DArr(testArr);
if (testArr.GetLength(0) == testArr.GetLength(1))
{
    Console.WriteLine(string.Empty);
    TraspArr(testArr);
    Print2DArr(testArr);
}
else
{
    Console.WriteLine("Данный метод транспонирует только квадратные матрицы");
}