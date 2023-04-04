// Задача 53
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
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

// void ReplaceRow(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReplaceRow(matrix);
// PrintMatrix(matrix);

// Задача 55 
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
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

// void ReplaceRow(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// while (size[0] != size[1]) // квадратный массив
// {
//     Console.Write("Вы ошиблись!\nВведите размеры двумерного массива: ");
//     size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReplaceRow(matrix);
// PrintMatrix(matrix);

// задача 57
// bool checkElement(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return false;
//     }
//     return true;
// }

// int inputMatrix(int[,] matrix, int[] array)
// {
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             if (checkElement(array, matrix[i, j]))
//             {
//                 array[k] = matrix[i, j];
//                 k++;
//             }
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
//     return k; // количество элементов в одномерном массиве
// }


// void SwapFirstLastString(int[,] matrix, int[] array, int countArray)
// {
//     for (int k = 0; k < countArray; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {       
//                 if (array[k] == matrix[i, j])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
//     }

// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// int[] array = new int[coord[0] * coord[1]];
// Console.WriteLine("Начальный массив: ");
// int countArray = inputMatrix(matrix, array);
// Console.WriteLine();
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SwapFirstLastString(matrix, array, countArray); 
// // нужен вспомогательный массив

// // Задача 57.2
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
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

// void DictionaryMatrix(int[,] matrix)
// {
//     int count = 1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             count = 1;
//             if (matrix[i, j] != -100)
//             {
//                 for (int k = 0; k < matrix.GetLength(0); k++)
//                 {
//                     for (int m = 0; m < matrix.GetLength(1); m++)
//                     {  
//                         if (matrix[i, j] == matrix[k, m] && (i != k || j != m))
//                         {
//                             matrix[k, m] = -100;
//                             count++;
//                         }
//                         // PrintMatrix(matrix);
//                         // Console.WriteLine();
//                     }
//                 }
//                 Console.WriteLine($"{matrix[i, j]} встречается {count} раз");
//             }
//         }
//     }
//     // PrintMatrix(matrix);
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Конечный массив:");
// DictionaryMatrix(matrix);

// задача 59
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void SwapFirstLastString(int[,] matrix)
{
    int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= minValue)
            {
                minValue = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    Console.WriteLine($"Минимум {minValue} на позиции({minRow + 1}, {minColumn + 1})");
    Console.WriteLine();
    Console.WriteLine("Конечный массив");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != minRow)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != minColumn)
                    Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix);
SwapFirstLastString(matrix);