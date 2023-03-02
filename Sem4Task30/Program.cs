// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}
int[] Gen1DArr(int len, int min, int max) //len позволяет нам сделать универсальное решение
{
    int[] arr = new int[len];
    for (int i = 0; i<8; i++) //arr.lenght
    {
        arr[i] = new Random().Next(min,max);
    }
    return arr;
}

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

Print1DArr(Gen1DArr(ReadData("Введите длину массива "),
 ReadData ("Введите минимальное число в масссиве"),
 ReadData ("Введите максимальное число в масссиве")));