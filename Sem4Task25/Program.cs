// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

//метод чтения данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод сложения чисел

int Summary(int numA, int numB)
{
    int result = numA + numB;
    return result;
}

//метод вычитания чисел

double Subtraction(int numA, int numB)
{
    double result = numA - numB;
    return result;
}

//метод деления чисел

double Division(int numA, int numB)
{

    double result = numA / numB; //не нашел способа проверки деления на 0
    return result;


}

// метод умножения чисел

int Multiplicatiion(int numA, int numB)
{
    int result = numA * numB;
    return result;
}

//метод возводящий в степень число

long Power(int numA, int numB)
{
    // long result = Math.Pow(numA, numB);
    long result = 1;
    while(numB>0)
    {
        result = result*numB;
        numB = numB - 1;
    }
    return result;
}


void PrintOption()
{
    Console.WriteLine("Данный калькулятор складывает, вычитает, умножает, делит, возводит в степень только 2 натуральных числа");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
}

PrintOption();

int option = ReadData("Выберите нужный вам метод с помощью цифр от 1 до 5 ");
int numberA = ReadData("Введите число A ");
int numberB = ReadData("Введите число B ");

if (option >= 1 && option <= 5) //не смог придумать универсальный метод для проверки корректности введенного числа и выбора метода
{
    if (option == 1)
    {
        Console.WriteLine($"{numberA} + {numberB} = " + Summary(numberA, numberB));
    }
    if (option == 2)
    {
        Console.WriteLine($"{numberA} - {numberB} = " + Subtraction(numberA, numberB));
    }
    if (option == 3)
    {
        Console.WriteLine($"{numberA} x {numberB} = " + Multiplicatiion(numberA, numberB));
    }
    if (option == 4)
    {
        Console.WriteLine($"{numberA} / {numberB} = " + Division(numberA, numberB));
    }
    if (option == 5)
    {
        Console.WriteLine($"{numberA} ^ {numberB} = " + Power(numberA, numberB));
    }
}
else
{
    Console.WriteLine("Вы ввели неккоректное число");
    Console.WriteLine("Пожалуйста перезапустите программу и выберите метод!");
}