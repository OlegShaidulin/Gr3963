// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.

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

void PrintData(string msg, int num)
{
    Console.WriteLine(msg + num);
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

int SumUnevenIndex(int[] arr)
{
    int sumNum = 0;

    for (int i = 1; i < arr.Length; i += 2) //т.к. в условии четко дано условие, будем сразу "прыгать" по нечетным позиициям
    {
        // if(i % 2 == 1)
        // {
        //     sumNum = sumNum + arr[i];
        // }
        sumNum = sumNum + arr[i];
    }
    return sumNum;
}

int[] testArr = Gen1DArr(10, 1, 6);
Print1DArr(testArr);
int result = SumUnevenIndex(testArr);
PrintData("сумма чисел в нечетных позициях массива: ", result);


