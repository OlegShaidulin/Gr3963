﻿//Задача 13:
//Напишите программу, которая выводит третью цифру заданного числа или сообщает
//, что третьей цифры нет.

//Вариант 1 
//Для дальнейшего перевода в массив, объявляем переменную, которую собираемся
//ввести с помощью string
string num = Console.ReadLine()??"0";
//Дальше, переводим число в массив с помощью команды char
char[] array = num.ToCharArray();
if (array.Length >= 3)
{
    //Выводим 2 цифру из массива данного числа
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("3 числа нет");
}

///Вариант 2 
//* Сделать вариант для числа длиной до 10 цифр не используя char или string

//Для того чтобы понять запустилась ли программа 
//вводим данную команду
Console.WriteLine("Введите число: ");
//По тех заданию, нам нужно избегать значения string и их объявления
//Я нашел выход только в том что можно сразу конвертировать в значение int
//и провести проверку на ошибочную пустую строку
int number = int.Parse(Console.ReadLine()??"0");
//Воспользуюсь методами, которые нам объясняли на лекции
//Chop переводится как рубить или отсекать, что собственно и делает этот медот
int Chop(int number)
{
    //Пока число слшком большое оно делится на 10, для того чтобы добиться нужной разрядности
    while (number > 999)
    {
        //"/=" дннай арифметический оператор обозначает, что число делиться на определенный аргумент
        //и после к числу присваивается полученное значение от деления
        number /= 10;
    }
    //
    return number % 10;
}
//оператор bool 1 битный, хотя занимает 1 байт памяти, в его возможных значения только true и false
//В этом методе мы проверям число на его разрядность
bool CorrectnessNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        //поэтому мы возвращаем логические значения с условий
        
        return false;
    }
    return true;
}

if (CorrectnessNumber(number))
{
    Console.WriteLine(Chop(number));
}



