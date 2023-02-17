//№4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
//этих чисел.
Console.WriteLine("ведите первое число");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите второе число");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите второе число");

int num3 = Convert.ToInt32(Console.ReadLine());


if (num1>num2)
{
    if(num1>num3)
    {
        Console.WriteLine("max = " +num1);
    }
    else
    {
        Console.WriteLine("max = " +num3);
    }
}
else
{
    if(num2>num3)
    {
        Console.WriteLine("max = " +num2);
    }
    else
    {
        Console.WriteLine("max = " +num3);
    }
}