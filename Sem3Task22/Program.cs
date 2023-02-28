// Задача №22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
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
int rate = ReadData("Введите степень ");
Console.WriteLine(LineBuilder(number, 1));
Console.WriteLine(LineBuilder(number, rate));