// Задача 68:
//  Напишите программу вычисления функции Аккермана с помощью рекурсии
// . Даны два неотрицательных числа m и n.

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода данных
void PrintData(string msg, int result)
{
    Console.WriteLine(msg+result);
}

int AkkermanFunk(int n,int m)
{
    if (n==0)
    {
        return m+1;
    }
    else if (m==0)
    {
        return AkkermanFunk(n-1,1);
    }
    else 
    {
        return AkkermanFunk(n-1,AkkermanFunk(n,m-1));
    }
}

PrintData("Результат: ",AkkermanFunk(ReadData("Введите число n "), ReadData("Введите число m")));