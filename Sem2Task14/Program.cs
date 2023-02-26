//Задача №14
//Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно 7 и
//23. 

int digit = int.Parse(Console.ReadLine()??"0");
//&& = "и" !! = "или" ! = "отрицание"
//bool oper = ((digit%23==0)&&(num%7==0))
//if (oper == true)

if((digit%23 == 0)&&(digit%7 == 0))
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}