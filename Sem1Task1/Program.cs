//Задача №1
//Напишите программу, которая на вход принимает
//два числа и проверяет, является ли первое число
//квадратом второго.


//Пишем в консоль 1 число
Console.WriteLine("ведите первое число");

string? numLine1 = Console.ReadLine();

//Пишем в онксоль 2 число
Console.WriteLine("введите второе число");

string? numLine2 = Console.ReadLine();

//Сравниваем равны ли они 0

if (numLine1 != null && numLine2 != null) ;
{
    //Переволим в инт
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if (num2 * num2 == num1)

    //Вывдоим все значения
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }
}
