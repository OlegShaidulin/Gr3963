// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}




//алгоритм через числа

int ChopNum(int numA)
{
    int count = 0;
    while (numA > 0)
    {
        count += numA % 10;
        numA /=10;
    }
    return count;
}





int numberA = ReadData("Введите число для метода через числа");
DateTime d1 = DateTime.Now;

Console.WriteLine("число полученное методом через числа"+ChopNum(numberA));
Console.WriteLine(DateTime.Now - d1);



