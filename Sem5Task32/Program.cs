// Задача №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

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
//примитивный тип переменной
//int a = 0
//void мет(int b)
// {
//     bool= bool+1
// }
//мет(a)
//Console.WriteLine(a); >>0
//ссылочный тип переменной
//int[] a = new arr[1]
//void мет(int[] b)
// {
//     b[0] = 100
// }
//мет(а);
//Console.WriteLine(a[a]); >>100
void Invers1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //arr[i] = arr[i] * (-1);
        arr[i] *= (-1);
    }
}
int[] testArr = Gen1DArr(10, -7, 7);
Print1DArr(testArr);
Invers1DArr(testArr);
Print1DArr(testArr);