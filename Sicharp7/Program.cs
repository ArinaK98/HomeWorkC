// Console.Clear();
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// Console.WriteLine(size[0] + size[1]);
// // Console.ReadLine()! ввод строки с исключением ноль
// // String.Split() разделение с пробелом поумолчанию возврат 
// //  массив строк
// // Select(x => int.Parse(x)) х случайная переменная 
// // из массива берем значение и применяем действие 
// //  в данном случае переводим тип данных
// // Select принимает и возвращает тот же тип данных
// //  ToArray(); переводит в массив

// // доп задача 
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

// int countEven = 0, countOdd = 0;
// // element принимает в себя значение массива
// // проходится по нему
// foreach (int element in array)
// {
//     if (element % 2 == 1)
//     {
//         Console.Write($"{element} ");
//         countEven++;
//     }
// }
// Console.WriteLine();
// foreach (int element in array)
// {
//     if (element % 2 == 0)
//     {
//         Console.Write($"{element} ");
//         countOdd++;
//     }
// }
// Console.WriteLine();
// if (countOdd >= countEven)
//     Console.WriteLine("YES");
// else
//     Console.WriteLine("NO");

// задача 46 массив 3 на 4 с случайными числами

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

// Console.Clear();
// Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// // задача 
// // массив 3 на 4 с случайными числами

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = i + j;
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// Задача 49 
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {    
//             matrix[i, j] = new Random().Next(1, 10); // [1, 10]
//         }
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

// void ChangeMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ( i % 2 != 0 & j % 2 != 0)
//                 matrix[i, j] *= matrix[i, j];
//                 Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ChangeMatrix(matrix);

// Задача 51
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [10; 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int ReleaseMatrix(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                result = result + matrix[i, j];
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
Console.WriteLine($"Результат {ReleaseMatrix(matrix)}");

