// Задача №20
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод передает данные пользователю
void PrintData(string msg, double val) // double вместо инт  тк  чисо вещественное
{
    Console.WriteLine(msg + val);
}
//Метод считает расстояние между точками
double CalkLen2D(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)); //вывод формулы из теоремы пифагора
}

int coordX1 = ReadData("Введите координату точки A X: ");
int coordY1 = ReadData("Введите координату точки A Y: ");
int coordX2 = ReadData("Введите координату точки B X: ");
int coordY2 = ReadData("Введите координату точки B Y: ");

double res = CalkLen2D(coordX1, coordY1, coordX2, coordY2);

PrintData("Расстояние между точками: ", res);