// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

int[] Gen1DArr(int len, int minValue, int maxValue) 

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

// void Swap1DArr(int[] arr)
// {
//     int bufElem = 0;
//     for(int i = 0; i < arr.Length/2; i++ )
//     {
//         bufElem = arr[i];
//         arr[i] = arr[arr.Length-1-i];
//         arr[arr.Length-1-i]=bufElem;
//     }
// }

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i = 0; i<outArr.Length; i++)
    {
        outArr[i]=arr[arr.Length-1-i];
    }

    return outArr;
}

int[] testArr = Gen1DArr(19,10,100);
Print1DArr(testArr);
Console.WriteLine(string.Empty);
// Swap1DArr(testArr);
// Console.WriteLine(string.Empty);
int[] newTestArr = SwapNewArray(testArr);
Print1DArr(newTestArr);
// Print1DArr(testArr);
// Console.WriteLine(string.Empty);
// int[] newTestArr = SwapNewArray(testArr);
// Print1DArr(newTestArr);
