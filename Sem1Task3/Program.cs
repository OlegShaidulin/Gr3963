//Задача №3
//Напишите программу, которая будет выдавать
//название дня недели по заданному номеру

//Называем номер дня недели

Console.WriteLine("Номер дня недели");

//Консоль читает номер дня недели

string? LineDay = Console.ReadLine();

//Проверяем на пустоту строку

if (LineDay != null);
{
    int day = int.Parse(LineDay);
    string[] dayWeek = new string[7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";

    Console.WriteLine(dayWeek[day-1]);

}


