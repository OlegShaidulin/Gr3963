// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.



//Метод считывания данных от пользования
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод проверки числа
bool PalinTest(int num)
{
    bool res = false; //изначально думаем что число не является палиндромом
    if (((num / 10000 == num % 10)) && ((num / 1000) % 10) == ((num / 10) % 10)) //сравниваем первую цифру и последнюю и вторую с предпоследней
    {
        res = true;
    }
    return res;
}
int digit = ReadData("Введите пятизначное число: ");
if (PalinTest(digit) == true)
{
    Console.WriteLine("Это число палиндром");
}
else
{
    Console.WriteLine("Это число не является палиндромом!");
}

// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
//Думаю было куда более изящное решение

//Создаем Словарь где будут содержаться числа(TypeKey) и логический операторы(ValueKey) true и false
Dictionary<int, bool> Numbers = new Dictionary<int, bool>();

//Метод получения данных от пользователя
int RetriveData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод заполнения словаря четырехзначными числами и логическими операторами
Dictionary<int, bool> StorageNumbers()
{
    var dictionary = new Dictionary<int, bool>();
    for (int i = 999; i < 10000; i++)
    {
        if (((i / 1000 == i % 10)) && ((i / 100) % 10) == ((i / 10) % 10))
        {
            dictionary.Add(i, true);
        }
        else
        {
            dictionary.Add(i, false);
        }
    }
    return dictionary;
}
//Метод для превращения пятизначного пользователя в четырехзначное
int TransformNum(int count)
{
    int countA = (count / 10000) % 10;     //|1|0000
    int countB = (count / 1000) % 10;      //1|0|000
    int countC = (count / 10) % 10;       //100|0|0
    int countD = count % 10;        //1000|0|
    int res = countA * 1000 + countB * 100 + countC * 10 + countD;
    return res;
}

int quantity = RetriveData("Введите пятизначное число ");

Numbers = StorageNumbers(); //Заполняем наш словарь, с помощью метода

bool result = Numbers[(TransformNum(quantity))]; //получаем ValueKey из нашего словаря
if(result == true)
{
    Console.WriteLine("Это число палиндром!");
}
else
{
    Console.WriteLine("Число не является числом палиндромом!");
}

