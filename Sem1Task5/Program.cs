//Задача №5
//Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N

//Console.Write("Введите число = ");

//var day = Convert.ToInt64(Console.Readline());
//var negDay = -day;

//for (; negDay <= day; negDay++);
//{
 //   Console.Write(negDay+ "\t");
//}

Console.Write("Введите число = ");

string? InputLine = Console.ReadLine();

//проверка чтобы данные не были пустые
if(InputLine != null)
{
    //Парсим певое число

    int inputNumber = int.Parse(InputLine);
    int startNumber = inputNumber*(-1);

    //Выходное значение
    string outline = string.Empty;
    while(startNumber<inputNumber)
    {
        outline = outline + startNumber + ", ";
        startNumber++;
    }
    outline = outline +inputNumber;

    //Вывдодим данные в консоль
    Console.WriteLine(outline);
}