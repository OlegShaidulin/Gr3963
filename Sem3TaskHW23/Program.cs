// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1

// Задача №22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.


//Метод принимает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод печатает строки в консоль и возводит в нужныую степень
string LineBuilder(int num, int pow)
{
    string res = String.Empty;

    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + "\t ";
    }
    return res;
}

int number = ReadData("Введите число N ");

Console.WriteLine(LineBuilder(number, 1));
Console.WriteLine(LineBuilder(number, 3));