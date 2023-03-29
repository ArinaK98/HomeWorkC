// Задача 41 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Задача 42 точка пересечения двух прямых

Console.WriteLine("Введите a1  ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1  ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите a2  ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2  ");
int b2 = Convert.ToInt32(Console.ReadLine());
int x = 0;
int y = 0;
int y1 = a1 * x + b1 ;
int y2 = a2 * x + b2 ;
x = (a1 - a2) / (b2 - b1);
if (y1 == y2)
    y = a1 * x + b1;
Console.WriteLine($"({x},{y})");


