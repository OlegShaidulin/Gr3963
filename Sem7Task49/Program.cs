// Задача №49
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.

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
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine(string.Empty);
    }
}

void Update2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {


            arr[i, j] *= arr[i, j];

        }
    }
    
}

int[,] test2DArr = Gen2DArr(8, 10, 1, 9);
Print2DArr(test2DArr);
Console.WriteLine(string.Empty);
Update2DArr(test2DArr);
Print2DArr(test2DArr);