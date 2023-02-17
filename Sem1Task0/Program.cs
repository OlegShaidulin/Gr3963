//Напишите программу, которая на вход принимает
//число и выдаёт его квадрат (число умноженное на
//само себя). 

//Вводим строку введите число

Console.WriteLine("Введите число= ");

//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверим, чтобы данные не были пустыми
if (inputNum != null)
{
    //Просим введенное число
    int number = int.Parse(inputNum);

    //Находим квадрат числа
    //int outNum = number * number;

    int outNum = (int)Math.Pow(number,2);

    //Выводим данные в консоль
    //Console.WriteLine(outNum);

    // Выводим число в консоль
    Console.WriteLine("Квадрат числа:"+outNum);

    //Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}