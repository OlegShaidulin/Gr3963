// Задача 66: Задайте значения M и N.
//  Напишите программу, 
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода данных
void PrintData(int value)
{
    Console.WriteLine(value);
}

int RecSumNumMN(int m, int n)
{
    if(m>=n)
    {
        return n;
    }
    else
    {
    return m+RecSumNumMN(m+1,n);
    }
}
PrintData(RecSumNumMN(ReadData("Число M "), ReadData("Число N ")));