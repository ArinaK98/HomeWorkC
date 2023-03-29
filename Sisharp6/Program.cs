// задача 39 смена первых и последних элементов

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1, 10]
// }


// void ReplaceElements(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] a = new int[n];
// InputArray(a);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", a)}]");
// ReplaceElements(a);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", a)}]");

// Задача 40

// Console.Clear();
// Console.WriteLine("Введите число 1  ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2  ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3  ");
// int c = Convert.ToInt32(Console.ReadLine());

// if ( a < b + c & b < a + c & c < a + b)
//     Console.WriteLine("такой треугольник существует");
// else 
//     Console.WriteLine("Такого треугольника не существует ");

// Задача 41 перевод в двоичную систему

// Console.Clear();
// Console.WriteLine("Введите число   ");
// int a = Convert.ToInt32(Console.ReadLine()!);
// string result = string.Empty;
// while (a > 0)
// {
//     result = Convert.ToString(a % 2) + result; 
//     // в строках инфа добавляется с лева на право
//     a /= 2;
// }
// Console.WriteLine(result);

// // задача 44 числа фибоначи

// Console.Clear();
// Console.WriteLine("Введите число   ");
// int n = Convert.ToInt32(Console.ReadLine()!);
// int a0 = 0;
// int a1 = 1, x;
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{a0} ");    
//     x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }

// Задача 45 копия одномерного массива происходит через поэлементное копирование
// Console.Clear();
// int[] a = {1, 2, 3, 4, 5};
// int[] b = new int[a.Length];

// for ( int i= 0; i < a.Length; i++)
//     b[i] = a[i];

// b[0] = b[0] + 10;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));
