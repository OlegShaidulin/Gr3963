//Задача №16
//Напишите программу, которая принимает на вход
//два числа и проверяет, является ли одно число
//квадратом другого

Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine()??"0");

//Метод void
void SqrTest(int numOne, int numTwo)
{
    if(numOne == numTwo*numTwo)
    {
        Console.WriteLine("Число " +numOne+ " квадрат числа " + numTwo );
    }
    else
    {
        Console.WriteLine("Число "+ numOne + " не является квадратом числа "+ numTwo);
    }
}
SqrTest(numA, numB);
SqrTest(numB, numA);