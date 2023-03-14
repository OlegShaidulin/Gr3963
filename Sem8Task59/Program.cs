// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

//метод поиска минимального элемента и его "координатЭ
(int outputRow, int outputColumn) SearchElemMin2DArr(int[,] arr)
{
    int outputRow = 0;
    int outputColumn = 0;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min < arr[i, j])
            {
                min = arr[i, j];
                outputRow = i;
                outputColumn = j;
            }
        }
    }
    return (outputRow, outputColumn);
}

//метод устраняющий строчки и массив
int[,] Update2DArray(int[,] arr, int row, int column)
{
    int[,] updArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0; int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != column && i != row)
            {
                updArr[k, m] = arr[i, j];
            }
            if (j != column)
            {
                m++;
            }
        }
        if (i != row)
        {
            k++;
        }
    }
    return updArr;
}

int m = ReadData("Введите количетсво строк: ");
int n = ReadData("Введите количесвто столбов: ");
int[,] test2DArr = Gen2DArr(m, n, 1, 99);
Print2DArr(test2DArr);
Console.WriteLine(string.Empty);
(int outputRow, int outputColumn) minElem = SearchElemMin2DArr(test2DArr);
int[,] outTestArr = Update2DArray(test2DArr, minElem.outputRow, minElem.outputColumn);
Print2DArr(outTestArr);