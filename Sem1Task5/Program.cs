//Задача №5
//Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N

Console.Write("Введите число = ");

var day = Convert.ToInt64(Console.Readline());
var negDay = -day;

for (; negDay <= day; negDay++);
{
    Console.Write(negDay+ "\t");
}