// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.

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
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int SearchElements(int[] arr, int elem) //bool SearchElements
{
    int res = -1; // bool res = false
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i + 1; //res = true
            break; //позволяет выйти из цикла и раньше завершить метод
        }
    }
    return res;
}

int[] testArr = Gen1DArr(10, -9, 9);
int value = ReadData("ВВедите число ");
Print1DArr(testArr);
if (SearchElements(testArr, value) > 0)
{
    Console.WriteLine(SearchElements(testArr, value));
}
else
{
    Console.WriteLine("Элемент не найден");
}