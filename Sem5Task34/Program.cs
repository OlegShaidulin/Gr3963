// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// 

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

int ChekEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] testArr = Gen1DArr(5, 99, 999);
Print1DArr(testArr);
int result = ChekEvenNum(testArr);
PrintData("Количество четных чисел в массиве: ", result);

// * Отсортировать массив методом пузырька

Console.WriteLine(string.Empty); //отделяем задание со *

//метод сортировки пузырьком
int[] BubleSort(int[] arr)
{
    int buble; //объявлем переменную, не важно какое значение оно сейчас примет
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++) //j начинает со 2 числа массива, т.к сравнивать 1 и тоже число бессмысленно
        {
            if (arr[i] > arr[j])
            {
                buble = arr[i];  //меняем местами с помощью 3 переменной
                arr[i] = arr[j];
                arr[j] = buble;
            }
        }
    }
    return arr;
}

DateTime d1 = DateTime.Now;

Print1DArr(BubleSort(testArr));

Console.WriteLine("Время работы пузырька");

Console.WriteLine(DateTime.Now - d1);

//метод сортировки подсчетом

int[] CountingSort(int[] arr)
{
    int min = 0;
    int max = 0;
    foreach (int element in arr)
    {
        if (element > max)
        {
            max = element;
        }
        else if (element < min)
        {
            min = element;
        }
    }
    int correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;

    var count = new int[max + 1];
    for (var i = 0; i < arr.Length; i++)
    {
        count[arr[i] + correctionFactor]++;
    }

    var index = 0;
    for (var i = 0; i < count.Length; i++)
    {
        for (var j = 0; j < count[i]; j++)
        {
            arr[index] = i - correctionFactor;
            index++;
        }
    }

    return arr;
}

DateTime d2 = DateTime.Now;

Print1DArr(CountingSort(testArr));

Console.WriteLine("Время работы подсчета");

Console.WriteLine(DateTime.Now - d2);


//

