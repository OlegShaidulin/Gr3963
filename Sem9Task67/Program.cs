// ---------------------------------------------------------------------
// Задача 67
// примает на вход число и возвращает сумму числа
// ---------------------------------------------------------------------

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода данных
void PrintData( int val)
{
    Console.WriteLine(val);
}

int RecSumDigit(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
    return num%10 + RecSumDigit(num/10);
    }
}


PrintData(RecSumDigit(ReadData(".....  ")));