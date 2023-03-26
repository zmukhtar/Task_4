// See https://aka.ms/new-console-template for more information
string nString = ""; 
Int64 factorial;
byte n; 

do
{ 
    Console.Write("Введите число от 0 до 255: ");
    nString = Console.ReadLine();
    bool result = byte.TryParse(nString, out byte i);
    if (result)
    {
        n = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);

factorial = 1;
for (int i = 2; i <= n; i++)
{
    factorial = factorial * i;
    
    
}
Console.Write($"n != {factorial}" );
