// //ввод чисел
// // Console.Clear();// очистка консоли
// // // int n = Convert.ToInt32(Console.ReadLine());
// // int n = int.Parse(Console.ReadLine()!);
// // Console.WriteLine(n * 3);

// // необходимо спросить у пользователя 2 числа и узнать наибольшее
// // 1 > 2
// // 2 > 1
// // 1 = 2
// Console.Clear();
// Console.Write(" Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// // // Интерполяция строк 
// // Console.WriteLine($" Результат {a} + {b} = {a + b}");
// // // Console.WriteLine(" Результат " + a + " + " + b + " = " + (a + b));
// // Console.WriteLine( a > b); // вывод true or false 
// if ( a > b)
//     Console.WriteLine(a);
// else if ( a < b)
//     Console.WriteLine(a);
// else 
//     Console.WriteLine("=");

// For (begin ; end ; step)
//  i++ <=> i = i + 1
// for(int i = 1; i <= 10; i++)
//     Console.Write($"{i}");
// Console.WriteLine();
// for(int i = 1; i <= 10; i+=2)
//     Console.Write($"{i}");
// Console.WriteLine();
// for(int i = 10; i > 0; i--)
//     Console.Write($"{i}");
// Console.WriteLine();

// Задание 1 демо
// Console.Clear();
// Console.Write(" Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a * a);

// Console.Clear();
// Console.Write(" Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write(" Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// if ( b*b == a )
//     Console.WriteLine(true);
// else 
//     Console.WriteLine("false");

// Console.Clear();
// Console.Write(" Введите цифру ");
// int a = Convert.ToInt32(Console.ReadLine());
// while (a < 1 || a > 7) // две палки или
// {
//     Console.Write(" Ошибка! \n Введите число от 1 до 7: ");
//     a = Convert.ToInt32(Console.ReadLine());
// }
// if ( a == 1)
//     Console.WriteLine("понедельник");
// else if ( a == 2)
//     Console.WriteLine("вторник");
// else if ( a == 3)
//     Console.WriteLine("среда");
// else if ( a == 4)
//     Console.WriteLine("четверг");
// else if ( a == 5)
//     Console.WriteLine("пятница");
// else if ( a == 6)
//     Console.WriteLine("суббота");
// else 
//     Console.WriteLine("воскресенье");

// Console.Clear();
// Console.Write(" Введите цифру ");
// // int a = Convert.ToInt32(Console.ReadLine()); 
// // for (int i = (-1)*a; i <= a; i++)
// //     Console.Write($"{i}");
// int a = Convert.ToInt32(Console.ReadLine()), i = (-1)*a; 
// a = Math.Abs(a); // модуль числа
// while (i <= a)
// {
//     Console.Write($"{i}");
//     i++;
// } 
