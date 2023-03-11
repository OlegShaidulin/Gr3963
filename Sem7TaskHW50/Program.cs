// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод расчитывающий числа для ряда Фибоначи
int FiboancciNumbers(int num)
{
    if (num <= 1)
    {
        return num;
    }
    return FiboancciNumbers(num - 1) + FiboancciNumbers(num - 2);
}

//метод генерирующий массив согласно ряду фибоначи

int[,] Gen2DArrFibonacci(int countRow, int countColumn)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = FiboancciNumbers(i * 3 + j);
        }
    }
    return arr;
}

// void Print2DArr(int[,] arr)
// {

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {

//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine(string.Empty);
//     }
// }

//данный метод является модификацией печати 2д массива(Print2DArr)
void SearchAndPaint(int[,] arr, int searchNumber)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == searchNumber)
            {
                // Расскраска найденного числа
               // Console.BackgroundColor = ConsoleColor.Yellow; //раскрашивание фона
                Console.ForegroundColor = ConsoleColor.Green; //раскрашивание самого числа
                Console.Write(arr[i, j] + "\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
//метод поиска числа по заданным номеру столба и строки
int SearchByPosition(int[,] arr, int serchRow, int serchColumn)
{
    if (serchColumn >= 0 && serchColumn < arr.GetLength(0) && serchRow >= 0 && serchRow < arr.GetLength(1))
    {
        return arr[serchColumn, serchRow];
    }
    else
    {
        return -1; //возвращаем значение -1 ,тк в ряде Фибоначи -1 нет
    }
}

int row = ReadData("Введите количество строк массива: ");
int column = ReadData("Введите количество столбов массива: ");


int[,] testArr = Gen2DArrFibonacci(row, column);

int numberSearchAndPaint = ReadData("Введите число для поиска: ");

int searchString = ReadData("Введите строку для поиска: ");
int serchCol = ReadData("Введите столб для поиска: ");


int numberSearchPosition = SearchByPosition(testArr, searchString, serchCol);

SearchAndPaint(testArr, numberSearchAndPaint);

if (numberSearchPosition != -1)
{
    Console.WriteLine($"Число найдено! Это: {numberSearchPosition}");
}
else
{
    Console.WriteLine("Этого числа не может быть в этом массиве");
    Console.WriteLine("Ошибка! Выход за пределы массива!");
}
