// See https://aka.ms/new-console-template for more information

Console.WriteLine("Проверка гипотезы Сиракуз.");


short n;

for (short i = 20; i <= 30; i++)
{
    n = i;
    while ((n<1)||(n>1))
    {
        if ((n%2) == 0)
        {
            n = (short)(n / 2);
        }
        else
        {
            n = (short)((3 * n + 1) / 2);
        }
        Console.Write($" |{n}|");
            
    }    
    Console.WriteLine();

}


