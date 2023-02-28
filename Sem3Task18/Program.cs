// Задача №18
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintAnswer(int num)
{
    if (num > 0 && num < 5)
    {
        if (num == 1) Console.Write("x>0, y>0");
        if (num == 2) Console.Write("x>0, y<0");
        if (num == 3) Console.Write("x<0, y<0");
        if (num == 4) Console.Write("x<0, y>0");
    }
    else
    {
        Console.WriteLine("Вы ввели не номер четверти");
    }
}
int quarter = ReadData("Введите номер четверти");
PrintAnswer(quarter);