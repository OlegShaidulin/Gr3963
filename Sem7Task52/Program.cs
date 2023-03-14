// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.

void Print1DArr(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(string.Empty);
    

}

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

double[] ColMean2DArr(int[,] arr)
{
    double[] resArr = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; j < arr.GetLength(0); i++)
        {
            resArr[j] += arr[i, j]; //Index was outside the bounds of the array.
        }
        resArr[j] = resArr[j] / arr.GetLength(0);
    }
    return resArr;
}

int[,] testArr = Gen2DArr(3, 3, 1, 9);
Print2DArr(testArr);
Print1DArr(ColMean2DArr(testArr));