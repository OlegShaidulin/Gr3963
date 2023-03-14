// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

double ReadData(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, (double, double) res) //в 1 переменную вкладываем 2 значения, это координаты нашей точки
{
    Console.WriteLine(msg + res);
}
//метод поиска точки пересечения
(double,double) FindPoint(double k1, double b1, double k2, double b2)
{
    double x=(b2-b1)/(k1-k2);
    double y=k2*x+b2;

    return (x,y);
}

PrintData("Точка пересечения двух прямых по заданным коэффициентам уравнения прямой ",
 FindPoint(ReadData("Введите коэффициент k1: "), ReadData("Введите коэффициент b1 "),
 ReadData("Введите коэффициент k2 "), ReadData("Введите коэффициент b2 ") ));
