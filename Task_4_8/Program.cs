// See https://aka.ms/new-console-template for more information
using static System.Math;


Console.WriteLine("Извлечение цифр числа.");

Int64 n;
do
{ 
    Console.Write("Введите целое число: ");
    string nString = Console.ReadLine();
    bool result = Int32.TryParse(nString, out int i);
    if (result)
    {
        n = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);

n = Abs(n);
while (n != 0)
{
    Console.WriteLine(n % 10);
    n = n / 10;
}
    
