//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
int digit = int.Parse(Console.ReadLine() ?? "0");
if (digit > 0 && digit < 6)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Выходной");
}
//* Сделать вариант с использованием конструкции Dictionary

//Вводим новый ссловарь используемые и вводим 2 параметра int для цифр и string для слов в строке
var WorkDays = new Dictionary<int, string>()
{
    [1] = "Рабочий день",
    [2] = "Рабочий день",
    [3] = "Рабочий день",
    [4] = "Рабочий день",
    [5] = "Рабочий день",
    [6] = "Выходной",
    [7] = "Выходной"
};
//для получения элемента из словаря и вывода его в консоль ыоспользуемся следующей командой
Console.WriteLine("Введите день недели: ");
//Пришлось конвертировать занчение из string в инт
string Days = WorkDays[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine(Days);
//для просмотра всего словаря WorkDays можно применить команду foreach
//foreach(var WorkDays in WorkDays)
//{
    //Console.WriteLine($"key: {WorkDays.Key} value: {WorkDays.Value})
//}