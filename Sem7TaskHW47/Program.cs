// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

double[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue) 

{
    //Блок корректировки входных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    double[,] arr = new double[countRow,countColumn];  
    

    for (int i = 0; i < countRow; i++) 
    {
        for(int j = 0; j< countColumn; j++)
        {
            arr[i,j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 4);
        }
    }
    return arr;
}

void Print2DArr(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                            ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                            ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                            ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                            ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                            ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine(string.Empty);
    }
}

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

Print2DArr(Gen2DArr(ReadData("Введите m строк: "), ReadData("Введите n столбов: "),
ReadData("Введите минимальное значение элемента массива: "),
ReadData("Введите максимальное значение элемента массива: ")));