// Написать программу которая из имен через запятую выберет случайное имя и выведет в 
// терминал Игорь, Антон, Сергей -> Антон Подсказка: Для разбора строки использовать метод
//  string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

// Основаня задача № 29, была решена на семинаре, смотри файл Sem4Task30

//Метод считывающий дынные пользователя
string ReadData(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

//Метод для вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

//Метод который перепечатывает и приводит к нужному виду список имён, который напечатал ползователь
void Print1DArr(string[] arr)
{
    Console.Write("Список имён: ");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.WriteLine(arr[arr.Length - 1]);

}


string name = ReadData("Введите список имен: ");


char[] commaAndSpace = new char[] { ' ', ',' };
string[] subs = name.Split(commaAndSpace, StringSplitOptions.RemoveEmptyEntries);

int randomNum = new Random().Next(0, subs.Length);
Print1DArr(subs);
Console.WriteLine();
PrintData($"Случайно выбраный человек: {subs[randomNum]}");