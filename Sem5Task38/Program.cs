// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.


double[] Gen1DArr(int len, int minValue, int maxValue) //len позволяет нам сделать универсальное решение

{
    //Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    double[] arr = new double[(int)len];  //использовали явное преведение
    Random rnd = new Random();

    for (int i = 0; i < len; i++) //arr.lenght
    {
        arr[i] = rnd.Next(minValue, maxValue + 1) + rnd.NextDouble(); //такая форма записи позволила добавит вещественные числа
    }
    return arr;
}

//метод печати массива

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

//метод вычисления максимального и минимального значения и вычисления разницы
double MaxMin(double[] arr)
{
    double res = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    res = max - min;
    return res;
}

//метод печати данных пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

double[] testArr = Gen1DArr(9,1,5);
Print1DArr(testArr);
PrintData("Разница между максимальным и минимальным значением: ", MaxMin(testArr));

//метод обмена элеметнтов
void Swap(ref double e1, ref double e2) //используем ссылочный тип данных для универсальности метода
{
    double temp = e1;
    e1 = e2;
    e2 = temp;
}

//вставочный метод сортировки 

double[] InsertionSort(double[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            double key = array[i];
            int j = i;
            while ((j > 1) && (array[j - 1] > key))
            {
                Swap(ref array[j - 1], ref array[j]);
                j--;
            }

            array[j] = key;
        }

        return array;
    }

Console.WriteLine(String.Empty);

Print1DArr(InsertionSort(testArr));