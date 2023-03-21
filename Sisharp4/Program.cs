// Array 
// Console.Clear();
// Console.Write(" введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// // создание массива
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // от 1 до 10
// Console.WriteLine($"[{string.Join(", ", array)}]");
// джоин принимает массив соединяет элементы массива через разделитель в строке

// // задача 24 сумма чисел до а
// Console.Clear();
// Console.Write(" введите кол-во элементов в массиве: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат {(1 + n) / 2 * n}");

// // задача 26 количество цифр
// Console.Clear();
// Console.Write(" введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (n > 0)//n!=0
// {
//     n = n /10;
//     count = count +1;//count++
// }
// Console.WriteLine($" {count}");

// // задача 28 факториал числа
// Console.Clear();
// Console.Write(" введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// for (int i = 2; i <= n; i++)
//     count = count * i;
// Console.WriteLine($" {count}");

// Задача 30

// генерация случайных дробных чисел
// Console.Clear();
// Console.Write(" введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
// Console.WriteLine($"[{string.Join(", ", array)}]");
    // new Random().NextDouble( генерирует случайных дробных чисел от 0 до 1
    //  * (end - begin) + begin
 