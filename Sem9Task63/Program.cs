//Задача 63 задайте N. Программа должна вывести числа от 1 до N. Выполнить с помощью рекурсию

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//рекурентный метод
void LineGenRec(int num)
{
    Console.Write(num + " ");
    if (num == 1)
    {

    }
    else
    {
        LineGenRec(num - 1);
    }
}
int number = ReadData("Введите число N: ");
LineGenRec(number);