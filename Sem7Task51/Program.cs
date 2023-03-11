// Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д



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

int SumMainDiag(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);
    for (int i = 0; i < min; i++)
    {
        res = res + arr[i,i];
    }
    return res;
}

void PrintData(string msg, int val) // double вместо инт  тк  чисо вещественное
{
    Console.WriteLine(msg + val);
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
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] test2DArr = Gen2DArr(ReadData("введите строки "),ReadData("введите столбцы "),1,100 );
Print2DArr(test2DArr);
PrintData("Сумма элементов главной диагонали ", SumMainDiag(test2DArr));
