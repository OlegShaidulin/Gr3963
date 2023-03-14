//№2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число
//большее, а какое меньшее

Console.WriteLine("ведите первое число");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите второе число");

int num2 = Convert.ToInt32(Console.ReadLine());


if (num1>num2)
{
    Console.WriteLine("max = " +num1);
}
else
{
    Console.WriteLine("max = " +num2);
}