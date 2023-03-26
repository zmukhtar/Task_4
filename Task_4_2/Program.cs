// See https://aka.ms/new-console-template for more information

// Task_4_2________________________________________________________________________________________________________

Console.WriteLine("Task_4_2. Вывести на экран кубы чисел от A до B, которые вводит пользователь.");

// A: 2
// B: 10
// 2 в кубе = 8
// 3 в кубе = 27
// 4 в кубе = 64
// 5 в кубе = 125
// 6 в кубе = 216
// 7 в кубе = 343
// 8 в кубе = 512
// 9 в кубе = 729
// 10 в кубе = 1000

string aNumberRead = "";
string bNumberRead = "";
int aNumber, bNumber;

do
{ 
    Console.Write("A: ");
    aNumberRead = Console.ReadLine();
    bool result = Int32.TryParse(aNumberRead, out int i);
    if (result)
    {
        aNumber = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);

do
{ 
    Console.Write("B: ");
    bNumberRead = Console.ReadLine();
    bool result = Int32.TryParse(bNumberRead, out int i);
    if (result)
    {
        bNumber = i;
        break;
    }
    Console.WriteLine("Некорректное число.");
} while (true);

for (int i = aNumber; i <= bNumber; i++)
{
    Console.WriteLine($"{i} в кубе = {i*i*i}");
}

