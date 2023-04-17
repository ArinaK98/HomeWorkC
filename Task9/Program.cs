//Задача 64

// void PrintNumber(int n, int count)
// {
//     if (count > n) return;
//     PrintNumber(n, count + 1);
//     Console.Write(count + ", ");
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// int n = InputNumbers("Введите N: ");
// int count = 2;
// PrintNumber(n, count);
// Console.Write(1);

// Задача 66
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SumFromMToN(m, n);

// Задача 68

// int Ackermann(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else
//       if ((m != 0) && (n == 0))
//         return Ackermann(m - 1, 1);
//     else
//         return Ackermann(m - 1, Ackermann(m, n - 1));
// }

// int m = 3, n = 2;
// Console.WriteLine(Ackermann(m, n));