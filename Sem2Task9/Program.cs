//Задача №9
//Напишите программу, которая выводит случайное
//число из отрезка [10, 99] и показывает наибольшую
//цифру числа.

System.Random numSintezator = new System.Random();

// Вариант 1

int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

if (firstNum > secondNum)
{
    Console.WriteLine("Первое число больше " + firstNum + " второго " + secondNum);
}
else
{
    Console.WriteLine("Второе число больше " + secondNum + " первого " + firstNum);
}

// Вариант 2

//char символы

char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
//выводим случайное значение в консоль
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

//<переменная> = (условие)?<значение1>:<значение2>;
//if(uslovie)
//{
    //<peremennaya> = (znachenie1);

//}
//else
//{
    //peremennaya> =(znachenie2);

//}

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;

//выводим результат в консоль
Console.WriteLine(resultNumber);