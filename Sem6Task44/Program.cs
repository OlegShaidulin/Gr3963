// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}



string FibNum(int num)
{
    string res = "0 1";
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 2; i < num; i++)
    {
        res = res + " " + (first + last).ToString();
        buf = last;
        last = last + first;
        first = buf;

    }
    return res;
}

PrintData("Ряд Фибоначчи: ",FibNum(ReadData("Введите первые N которые напечатаем ")));