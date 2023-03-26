// See https://aka.ms/new-console-template for more information

// Task_4_1________________________________________________________________________________________________________

Console.WriteLine("Task_4_1. Вывести все квадраты натуральных чисел, не превосходящие данного числа N.");
//Например, если N = 50, то на экран должен быть выведен ряд 1 4 9 16 25 36 49.

string nNumberRead = "";
int nNumber, xNumber, yNumber;

do
{ 
    Console.WriteLine("Введите предел:");
    nNumberRead = Console.ReadLine();
    bool result = Int32.TryParse(nNumberRead, out int i);
    if (result)
    {
        nNumber = i;
        xNumber = 1;
        yNumber = 1;

        while (yNumber < nNumber)
        {
            Console.Write($"{yNumber} ");
            xNumber += 1;
            yNumber = (xNumber*xNumber);
        }

        break;
        
    }
    Console.WriteLine("Некорректное число.");
} while (true);

//_________________________________________________________________________________________________________________