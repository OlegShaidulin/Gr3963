// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData( int num)
{
    Console.WriteLine( num);
}

int DigitSum(int num)
{
    int res = 0;
    while(num>0)
    {
        res +=1;
        num /=10;
        // res= Math.Floor(Math.Log10(num))+1;
        // res = num.ToString().Length;
    }
    return res;
}

int numA = ReadData("Введите число: ");
int result = DigitSum(numA);
PrintData(result);