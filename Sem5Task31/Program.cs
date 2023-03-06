// Задача №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.

//Генерация одномерного массива


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
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Печать одномерного массива

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

//метод высчтывающий суммы орицтельных и положительных значений массива
(int posit, int negat) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negatSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negatSum += arr[i];
        }
    }
    return (positSum, negatSum);
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
//(a, b) использовали для того чтобы в 1 переменной хранилось 2 значения
(int posit, int negat) result = NegPosSum(testArr);
PrintData("Сумма положителных значений массива: ", result.posit);
PrintData("Сумма отрицательных значений массива: ", result.negat);