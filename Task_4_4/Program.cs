// See https://aka.ms/new-console-template for more information

double x, y;

Console.WriteLine("Используя цикл написать программу, которая выводит на экран таблицу значений функции " +
                  "y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.");

x = -5;
Console.WriteLine(" X      Y");

while (x <= 5)
{
    y = 5 - x * x / 2;
    Console.WriteLine($"{x.ToString("0.0")} | {y.ToString("0.00")}");
    x = x + 0.5;
}




// x := -5;

// writeln(' x      y  ');
    
// while x <= 5 do begin
// y := 5 - x*x/2;
// writeln(x:4:1,' | ',y:5:2);
// x := x + 0.5





