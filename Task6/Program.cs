// Задача 41 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Задача 42 точка пересечения двух прямых

// Console.WriteLine("Введите a1  ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b1  ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите a2  ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2  ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// int x = 0;
// int y = 0;
// int y1 = a1 * x + b1 ;
// int y2 = a2 * x + b2 ;
// x = (a1 - a2) / (b2 - b1);
// if (y1 == y2)
//     y = a1 * x + b1;
// Console.WriteLine($"({x},{y})");

int[] coord = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int x1 = coord[0];
int y1 = coord[1];
int x2 = coord[2];
int y2 = coord[3];
int x3 = coord[4];
int y3 = coord[5];
double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
double B = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double C = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
double p = (A + B + C) / 2;
double S = Math.Sqrt(p * (p - A)  * (p - B) * (p - C));
Console.WriteLine(S);
