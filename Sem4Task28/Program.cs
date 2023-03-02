// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

using System.Numerics;

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, BigInteger num)
{
    Console.WriteLine(msg + num);
}

BigInteger Factorial(int num)
{
    BigInteger res = 1;
    for(int i = 1; i<=num; i++)
    {
        res = res * i;
    }
    return res;
}
int numberA = ReadData("Введите число ");
PrintData("Факториал числа равен ", Factorial(numberA));