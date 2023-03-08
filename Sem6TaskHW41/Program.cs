// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь
//Метод ввода данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод вывода данных пользователя
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}
//метод считающий количество положительных значений
int CountNum(int numM)
{
    int res = 0;
    for(int i = 0; i < numM; i++)
    {
        if(ReadData(" ")>0)
        {
            res++;
        }
    }
    return res;
}

PrintData(" ", CountNum(ReadData("Введите M чисел ")));