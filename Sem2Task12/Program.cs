//Задача №12
//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе
//число кратным первому. Если второе число
//некратно первому, то программа выводит остаток от
//деления.

Console.Write("ВВедите первое число ");
int firstNum = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число ");
int scndNum = Convert.ToInt32(Console.ReadLine());
// так как вычисление повторяется вводим 3 переменную, для удобства чтения
int rem = firstNum % scndNum;

if (rem == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно " + "остаток = " + rem);
}