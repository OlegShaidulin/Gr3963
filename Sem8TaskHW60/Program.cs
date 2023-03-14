// Задача 60. 
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Gen3DArr(int Row, int Coloumn, int power, int min, int max)
{

    int[,,] arr = new int[Row, Coloumn, power];
    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Coloumn; j++)
        {
            for (int k = 0; k < power; k++)
            {
                arr[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return arr;
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(2); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[j, k, i]} ({j},{k},{i})" + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int coloumn = ReadData("Введите количество столбцов: ");
int power = ReadData("Введите мощность 3х мерной матрицы: ");
int[,,] mas1 = Gen3DArr(row, coloumn, power, 10, 99);
Print3DArr(mas1);