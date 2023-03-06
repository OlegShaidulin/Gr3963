// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.

int[] Gen1DArr(int len, int minValue, int maxValue) //len позволяет нам сделать универсальное решение

{
    //Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    int[] arr = new int[len];
    for (int i = 0; i < len; i++) //arr.lenght
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

int[] ConvertArr(int[] arr) //не подходит для нечетных, серединка умножает саму на себя -> [1,3,2] ->[2,9]
{
    // if (arr.Length % 2 == 1)
    // {
    //     arr.Length = arr.Length + 1;
    // }
    int[] buffArr = new int[(arr.Length / 2) + 1];
    for (int i = 0; i < ((arr.Length / 2) + 1); i++) 
    {
        buffArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return buffArr;
    // int len = arr.Length/2;
    // int[] buffArr = new int[len+1];
    // for(int i = 0; i<buffArr.Length;i++)
    // {
    //     buffArr[i]=arr[i]*arr[len - i];
    // }
    // return buffArr;
}

int[] testArr = Gen1DArr(3, 1, 3);
Print1DArr(testArr);
int[] testConvertArr = ConvertArr(testArr);
Print1DArr(testConvertArr);