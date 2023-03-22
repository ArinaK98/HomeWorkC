// методы - обращение к объекту и выполнение действия
// функция, процедура - участок кода к которому можно обращаться
// awyrwbb и процедуры пишутся только в начале программы

// Процедура - выполняет действия но ничего не возвращает

// void f(ref int a); // в скобках значение для переменных
// {
//     a = a +1;
// }
// Console.Clear();
// int n = 5;
// f(ref n);
// Console.WriteLine(n);
// ref - передача значения

// void f( int[] a); // для массивов
// {
//     a[] += 100;
// }
// Console.Clear();
// int[] array = {1,2,3,4,5};
// f(array);
// Console.WriteLine(string.Join(" ", array));

// Функции - принимает значения и изменяет их(возвращает)
// в начале указать тип возращаемых данных
// принимает два числа и возвращает максимальное


// int maxNumbers(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }

// Console.Clear();
// int n = 10, m = 7;
// Console.WriteLine(maxNumbers(n, m));
// int result = maxNumbers( n, m);
// Console.WriteLine(result);

// return после выполнения останавливает программу

// задача 31
// void InputArray(int[] array) // заведение массива
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);// [-9; 9]
// }

// int SumPositiveNumbers(int[] array)
// {
//     int sum = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             sum += array[i];// sum = sum + array[i]
//     }
//     return sum;
// }

// int SumNegativeNumbers(int[] array)
// {
//     int sum = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             sum += array[i];// sum = sum + array[i]
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве:");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($" Начальный массив: [{string.Join(",", array)}]");
// Console.WriteLine($" Сумма положительных элементов = { SumPositiveNumbers(array)}");
// Console.WriteLine($" Сумма отрицательных элементов = { SumNegativeNumbers(array)}");

// Задача 32
// void InputArray(int[] array) // заведение массива
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);// [-9; 9]
// }

// void ChangeNumbers(int[] array)
// {
//     for ( int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве:");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($" Начальный массив: [{string.Join(",", array)}]");
// ChangeNumbers(array);
// Console.WriteLine($" Новый массив: [{string.Join(",", array)}]");

// Задача 33

//  void InputArray(int[] array) // заведение массива
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);// [-9; 9]
// }

// string SearchNumberInArray(int[] array, int number)
// {
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return "yes";
        
//     }
//     return "no";
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве:");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($" Начальный массив: [{string.Join(",", array)}]");
// Console.Write("Введите число ");
// int k = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SearchNumberInArray(array, k));

// задача 35 кол-во элементов

//  void InputArray(int[] array) // заведение массива
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101);// [-100; 100]
// }

// int SearchNumberInArray(int[] array)
// {
//     int count = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 & array[i] <100)
//             count++;       
//     }
//     return count;
// }

// Console.Clear();
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($" Начальный массив: [{string.Join(",", array)}]");
// Console.WriteLine(SearchNumberInArray(array));

// задача 37 произведение пар чисел

 void InputArray(int[] array) // заведение массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);// [-100; 100]
}

void Proizvedenie(int[] array)
{
    for ( int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.WriteLine($"{array[i] * array[array.Length - 1 - i]}");
}

Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine($" Начальный массив: [{string.Join(",", array)}]");
Proizvedenie(array);