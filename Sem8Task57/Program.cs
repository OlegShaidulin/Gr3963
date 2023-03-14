// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных

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

//метод печати 1D массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
    Console.WriteLine(string.Empty);
}
//метод заполнения словаря
int[] FreqDicBuild(int[,] arr, int len)
{
    int[] mass = new int[len];
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1); j++)
        {
            mass[arr[i,j]]++;
        }
    }
    return mass;
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбов: ");
// int min = ReadData("Введите минимально возможное значение словаря: ");
// int max = ReadData("Введите максимально возможное значение словаря: ");
int[,] testArr = Gen2DArr(m, n, 0, 9);
Print2DArr(testArr);
Console.WriteLine(string.Empty);
Print1DArr(FreqDicBuild(testArr, 10));