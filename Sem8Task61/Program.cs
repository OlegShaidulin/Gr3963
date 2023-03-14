// Задача №61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//n!/k!*(n-k)!

long Factorial(int n)
{
    int res = 1;
    for (int i = 1; i <=n; i++)
    {
        res = res * i;
    }
    return res;
}

void PrintPaskalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int k = 0; k<nRow - i; k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
        }
        Console.WriteLine(" ");
    }
}
int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPaskalTriangle(countRow);