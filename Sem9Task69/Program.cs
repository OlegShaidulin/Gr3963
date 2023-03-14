

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода данных
void PrintData( long val)
{
    Console.WriteLine(val);
}

long RecPow(int a , int b)
{
    if(b<=1) return a;
    return a*RecPow(a,b-1);
}

PrintData(RecPow(ReadData("основание "), ReadData("степень ")));