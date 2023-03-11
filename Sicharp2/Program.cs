// Console.Clear();
// int n = new Random().Next(10, 100); // [10, 99]перво число входит, а другое нет 
// Console.WriteLine($" Случайное сгенерированное числа {n}");
// int n1 = n / 10;
// int n2 = n % 10;
// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);

// ввод случайного трехзначного числа и удалить вторую цифру
// Console.Clear();
// int n = new Random().Next(100, 1000); // [100, 999]перво число входит, а другое нет 
// Console.WriteLine($" Случайное сгенерированное числа {n}");
// int n1 = n / 100;
// int n2 = n % 10;
// Console.WriteLine(n1*10 + n2);


// является ли второе число кратно первому
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (n1 % n2 == 0)
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine($"не кратно, остаток {n1 % 10}");

// является ли  число кратным 7 и 23
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 & n % 23 == 0 ) // n % 161 =0
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine("не кратно");

// является ли одно из чисел квадратом другого
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (n1*n1 == n2 || n2*n2 == n1 ) // n % 161 =0
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine("не кратно");