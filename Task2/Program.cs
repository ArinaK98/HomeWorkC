// Задача 10 трехзначное число на вход и показать вторую цифру числа
// Console.Clear();
// int n = new Random().Next(100, 1000); // [100, 999]перво число входит, а другое нет 
// Console.WriteLine($"Случайное сгенерированное число {n}");
// int n1 = n % 100;
// Console.WriteLine(n1/10);

// Задача 13 третья цифра заданного числа или ее отсутствие
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (Math.Abs(n) < 100)
//     Console.WriteLine("Третьей цифры нет");
// else if ( Math.Abs(n) < 1000 & Math.Abs(n) > 99)
//     Console.WriteLine($"Третья цифра {n % 10}");
// else if ( Math.Abs(n) < 10000 & Math.Abs(n) > 999)
//     Console.WriteLine($"Третья цифра {(n % 100)/10}");
// else if ( Math.Abs(n) < 100000 & Math.Abs(n) > 9999)
//     Console.WriteLine($"Третья цифра {(n % 1000)/100}");
// else if ( Math.Abs(n) < 1000000 & Math.Abs(n) > 99999)
//     Console.WriteLine($"Третья цифра {(n % 10000)/1000}");
// else if ( Math.Abs(n) < 10000000 & Math.Abs(n) > 999999)
//     Console.WriteLine($"Третья цифра {(n % 100000)/10000}");
// else if ( Math.Abs(n) < 100000000 & Math.Abs(n) > 9999999)
//     Console.WriteLine($"Третья цифра {(n % 1000000)/100000}");
// else if ( Math.Abs(n) < 1000000000 & Math.Abs(n) > 99999999)
//     Console.WriteLine($"Третья цифра {(n % 10000000)/1000000}");
// else if ( Math.Abs(n) < 10000000000 & Math.Abs(n) > 999999999)
//     Console.WriteLine($"Третья цифра {(n % 100000000)/10000000}");
// else
//     Console.WriteLine("Превышен допустимый диапазон значений");


// Задача 15  на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 7) 
// {
//     Console.Write("Ошибка! \nВведите число от 1 до 7: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 7 || n == 6 )
//     Console.WriteLine("выходной");
// else
//     Console.WriteLine("не выходной");

