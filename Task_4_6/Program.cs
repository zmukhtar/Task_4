// See https://aka.ms/new-console-template for more information
int a, b, c, n;
Console.WriteLine("Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.");


do
{ 
    Console.Write("n = ");
    string nReadLine = Console.ReadLine();
    bool result = Int32.TryParse(nReadLine, out int i);
    if (result)
    {
        n = i;

        break;
        
    }
    Console.WriteLine("Некорректное число.");
} while (true);

a = 0;
Console.Write($"{a} ");
b = 1;
Console.Write($"{b} ");

for (int i = 3; i <= n; i++)
{
    Console.Write($"{a+b} ");
    c = b;
    b = a + b;
    a = c;
}
