// ---------------------------------------------------------------------
// Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
// ---------------------------------------------------------------------

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод вывода данных

void PrintData(string value)
{
    Console.WriteLine(value);
}

//рекурентый метод
string RecMN(int m, int n)
{
    string res = string.Empty;
    if (m >= n)
    {
        res = n.ToString();
    }
    else
    {
        res = res + m + " " + RecMN(m + 1, n);
    }
    return res;
}

int number1 = ReadData("Введите 1 число ");
int number2 = ReadData("Введите 2 число ");
string result =number1<number2? RecMN(number1, number2):RecMN(number2,number1);
PrintData(result);