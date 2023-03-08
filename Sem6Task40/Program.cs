// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, bool res)
{
    Console.WriteLine(msg+res);
}

bool Test(int a, int b, int c)
{
    return(a<=b+c);
}

bool TriangleTest(int a, int b, int c)
{
    bool res =false;
    if(Test(a,b,c)&&Test(b,a,c)&&Test(b,c,a))
    {
        res = true;
    }
    return res;
}

PrintData("Результат проверки: ", TriangleTest(
ReadData("Введите величину стороны A: "),
ReadData("Введите величину стороны B: "),
ReadData("Введите величину стороны C: ")));