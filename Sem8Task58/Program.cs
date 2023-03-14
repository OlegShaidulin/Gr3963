// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

//метод перемножение матриц
int[,] MultipArr(int [,] arr1,int [,] arr2)
{
    int[,]  res= new int[arr1.GetLength(0),arr2.GetLength(1)];
    for(int i=0;i<arr1.GetLength(0);i++)
    {
        for(int j=0;j<arr1.GetLength(1);j++)
        {
            for(int k=0;k<arr1.GetLength(1);k++)
            {
                res[i,j]+=arr1[i,k]*arr2[k,j];
            }
        }
    }
    return res;
}

int m = ReadData("Введите количетсво строк: ");
int n = ReadData("Введите количесвто столбов: ");

int[,] test2DArr1 = Gen2DArr(m, n, 1, 10);
Print2DArr(test2DArr1);
Console.WriteLine(string.Empty);
int[,] test2DArr2 = Gen2DArr(m, n, 1, 10);
Print2DArr(test2DArr2);
Console.WriteLine(string.Empty);

int[,] multiArr= MultipArr(test2DArr1,test2DArr2);
Print2DArr(multiArr);