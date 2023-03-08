// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}

string DecToBin(int num)
{
    string res = string.Empty;
    while(num>0)
    {
        res = num % 2 + res ;
        num = num/2;
    }
    return res;
}

PrintData("Результат преобразований: ", DecToBin(ReadData("Введите число: ")));