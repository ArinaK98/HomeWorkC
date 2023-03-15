// Console.Clear();
// string s = Console.ReadLine()!;
// int sum = 0;
// // нахождение суммы цифр числа
// for (int i = 0; i < s.Length; i++)
//     sum = sum + int.Parse(s[i].ToString());
//     Console.WriteLine(sum);
// // обращение к строке и перевод в строку далее строку переводим в число
//     // s[i] - символьный тип данных

// // на вход точки x и y и выдает номер четверти плоскости
// Console.Clear();
// Console.WriteLine("Введите координату X ");
// double X = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату Y ");
// double Y = Convert.ToDouble(Console.ReadLine());
// while (X == 0) 
// {
//     Console.Write("Ошибка! \n Введите координату X: ");
//     X = Convert.ToDouble(Console.ReadLine());
// }
// while (Y == 0) 
// {
//     Console.Write("Ошибка! \n Введите координату Y: ");
//     Y = Convert.ToDouble(Console.ReadLine());
// }
// if (X > 0 & Y > 0)
//     Console.WriteLine("четверть 1");
// else if (X < 0 & Y > 0)
//     Console.WriteLine("четверть 2");
// else if (X < 0 & Y < 0)
//     Console.WriteLine("четверть 3");
// else 
//     Console.WriteLine("четверть 4");

// Console.Clear();
// Console.WriteLine("Введите номер четверти ");
// int X = Convert.ToInt32(Console.ReadLine());
// while (X > 4 || X < 1) 
// {
//     Console.Write("Ошибка! \n Введите номер четверти от 1 до 4 ");
//     X = Convert.ToInt32(Console.ReadLine());
// }
// if (X == 1)
//     Console.WriteLine("(X > 0 и Y > 0)");
// else if (X == 2)
//     Console.WriteLine("X < 0 и Y > 0");
// else if (X == 3)
//     Console.WriteLine("X < 0 и Y < 0");
// else 
//     Console.WriteLine("X > 0 и Y < 0");

// Расстояние между точками
// Console.Clear();
// Console.WriteLine("Введите координату X(1) ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату X(2) ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату Y(1) ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату Y(2) ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double s = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y2-y1, 2));
// // Math.Sqrt - квадратный корень числа 
// // Math.Pow принимает в себя два значения выражение и степень возведения 
// Console.WriteLine($"Расстояние между двумя точками {Math.Round(s, 2)}");
// // Math.Round(s, 2) округление до кол-ва знаков

//  Выдать таблицу квадратов от 1 до N
// Console.Clear();
// Console.WriteLine("Введите число  ");
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= a; i++)
//     Console.Write($"{Math.Pow(i, 2)}");
     // Console.WriteLine($"{i} ^ 2 = {i * i}");
    