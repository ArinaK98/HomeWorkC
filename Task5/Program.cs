// задача 34 массив и кол-во четных чисел в нем

//  void InputArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);// [100; 999]
// }

// int Chetnye(int[] array)
// {
//     int count = 0;
//     for ( int i = 0; i < array.Length; i++)
//     {
//         if (array[i] %2 == 0)
//             count++;       
//     }
//     return count;
// }

// Console.Clear();
// int[] array = new int[10];
// InputArray(array);
// Console.WriteLine($" Начальный массив: [{string.Join(",", array)}]");
// Console.WriteLine(Chetnye(array));

// задача 36 массив и кол-во четных чисел в нем

//  void InputArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101);// [-100; 100]
// }

// int SumNeChetnye(int[] array)
// {
//     int sum = 0;
//     for ( int i = 1; i < array.Length; i= i+2)
//     {
//         if ( i < array.Length)
//             sum += array[i]; 
//     }
//     return sum;
// }

// Console.Clear();
// int[] array = new int[10];
// InputArray(array);
// Console.WriteLine($" Начальный массив: [{string.Join(",", array)}]");
// Console.WriteLine(SumNeChetnye(array));

// задача 38 разница между максимальным и минимальным

//  void InputArray(double[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round(new Random().NextDouble() * 100 , 2);
// }

// double Max(double[] array)
// {
//     double max = array[0];
//     for ( int i = 1; i < array.Length; i= i++)
//     {
//         if ( array [i] > max)
//             max = array[i];
//         else i++; 
//     }
//     return max;
// }

// double Min(double[] array)
// {
//     double min = array[0];
//     for ( int i = 1; i < array.Length; i= i++)
//     {
//         if ( array [i] < min)
//             min = array[i];
//         else i++; 
//     }
//     return min;
// }

// Console.Clear();
// double[] array = new double[10];
// InputArray(array);
// Console.WriteLine($" Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(Math.Round(Max(array) - Min(array), 2));
