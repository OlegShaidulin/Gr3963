//Задача №11
//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//Например:
//456 -> 46
//782 -> 72
//918 -> 98 

//генерируем число
int num = new Random().Next(100, 1000);

//вывдоим чилсо
Console.WriteLine(num);

//находим первую и последнюю цифру числа

int lastDigit = num % 10;
int firstDigit = num / 100;

//"Собираем" его
int result = firstDigit*10 + lastDigit;

//выводим это число

Console.WriteLine(result);

//можно было записать "просто" Console.Writeline((num/100)*10 + (num%10));