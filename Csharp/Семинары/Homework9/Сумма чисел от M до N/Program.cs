// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

// int summa = 0;
// if (M == N)
// {
//     summa = M;
//     Console.WriteLine($"Ответ: сумма чисел в промежутке M до N = {summa}");
// }
// if (M < N)
// {
//     for (int i = M; i <= N; i++)
//     {
//         summa += i;
//     }
//     Console.WriteLine($"Ответ: сумма чисел в промежутке M до N = {summa}");
// }
// if (N < M)
// {
//     for (int i = N; i <= M; i++)
//     {
//         summa += i;
//     }
//     Console.WriteLine($"Ответ: сумма чисел в промежутке M до N = {summa}");
// }

int SummaChisel(int m, int n)  // решение через рекурсию
{
    if (m < n)
    {
        return m + SummaChisel(m + 1, n);
    }
    else if (n < m)
    {
        return n + SummaChisel(m, n + 1);
    }
    else return m;
}

Console.Write("Ответ: сумма чисел в промежутке M до N = ");
Console.WriteLine(SummaChisel(M, N));