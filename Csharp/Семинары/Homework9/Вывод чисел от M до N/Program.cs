// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (M == N)
{
    Console.WriteLine($"Ответ: числа в промежутке M до N = {M}");
}
if (M < N)
{
    Console.WriteLine("Ответ: числа в промежутке M до N = ");
    for (int i = M; i <= N; i++)
    {
       Console.Write(i + " ");
    }
}
if (N < M)
{
    Console.WriteLine("Ответ: числа в промежутке M до N = ");
    for (int i = N; i <= M; i++)
    {
       Console.Write(i + " ");
    }
}

// void Recursion(int n, int m) решение через рекурсию
// {
//     if (m > n)
//     {
//         return;
//     }
//     Console.Write(m + " ");
//     Recursion(n, m + 1);
// }
// Recursion(N, M);
