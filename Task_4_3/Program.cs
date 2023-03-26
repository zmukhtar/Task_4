using static System.Math;
// See https://aka.ms/new-console-template for more information

int deg;
double num, res;


Console.WriteLine("Task_4_3 Написать программу на языке C#, которая возводит число в целочисленную степень. Число и степень вводятся с клавиатуры.");

do
{ 
    Console.Write("Число: ");
    string numString = Console.ReadLine();
    bool result = double.TryParse(numString, out double i);
    if (result)
    {
        num = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);

do
{ 
    Console.Write("Степень: ");
    string degString = Console.ReadLine();
    bool result = Int32.TryParse(degString, out int i);
    if (result)
    {
        deg = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);

res = 1;

for (int i = 1; i <= Abs(deg); i++)
{
    res = res * num;
    
    
}
if (deg < 0)
{
    res = 1 / res;
        
}
Console.WriteLine(res.ToString("0.000"));
