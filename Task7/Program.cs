// Задача 47
// void InputMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 2); 
//     }
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// Задача 50
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 10); 
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void FindElementMatrix(int[,] matrix, int x, int y)
// {
//     for (int i = 1; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j+=2)
//         {
//             if (x <= matrix.GetLength(1) & y <= matrix.GetLength(0))
//             {
//                 i = x;
//                 j = y;
//                 Console.Write($"{matrix[i, j]}");
//                 break;
//             }
//             else 
//             {
//                 Console.Write("нет такой позиции");
//                 break;
//             }
//         }

//     }
// }

// Console.Clear();
// Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив");
// PrintMatrix(matrix);
// Console.Write("Введите x позиции: ");
// int x = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите y позиции: ");
// int y = Convert.ToInt32(Console.ReadLine()!);
// FindElementMatrix(matrix, x, y);

