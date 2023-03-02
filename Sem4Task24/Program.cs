// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
long ReadData(string msg)
{
    Console.Write(msg);
    return long.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

long SumSimple(long numA)
{
    long sum = 0;

    for (long i = 1; i <= numA; i++)
    {
        sum += i; //sum = sum + i
    }
    return sum;
}

long SumGausse(long sumB)
{
    // long sumB = 0;
    // sumB = ((1 + sumB)*sumB);

    return ((1 + sumB) * sumB) / 2;
}

long numberA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до A(простой способ)" + res1);
PrintData("Сумма чисел от 1 до A(Метод Гаусса)" + res2);