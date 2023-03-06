// Задача №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
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
int NumElemInRange(int[] arr, int minValue, int maxValue) 
{
    int res = -1;  //res = -1
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] > minValue) && (arr[i]<maxValue))
        {
            res++ ; //res = true
        }
    }
    return res;//(res==-1)?res:res+1
}

void PrintData(string msg, int num)
{
    Console.WriteLine(msg + num);
}

int[] testArr = Gen1DArr(123, -50, 50 );
Print1DArr(testArr);
int value = NumElemInRange(testArr, 10, 99); //ReadData("Введите начальное значение отрезка "), ReadData("Введите конечное значение отрезка "));
PrintData("Полученное значение: ", value);
//1 41