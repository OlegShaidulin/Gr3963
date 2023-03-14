// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//  Выполнить с помощью рекурсии.

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода данных

// void PrintData(string value)
// {
//     Console.WriteLine(value);
// }
void LineGenRec(int n)
{
    if (n == 1)
    {
        Console.Write(n + "");
    }
    else
    {

        LineGenRec(n - 1);
        Console.Write(n + " ");
    }
}

LineGenRec(ReadData("Введите число N: "));