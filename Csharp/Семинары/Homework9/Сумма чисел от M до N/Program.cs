// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int summa = 0;
if (M == N)
{
    summa = M;
    Console.WriteLine($"Ответ: сумма чисел в промежутке M до N = {summa}");
}
if (M < N)
{
    for (int i = M; i <= N; i++)
    {
       summa +=i;
    }
    Console.WriteLine($"Ответ: сумма чисел в промежутке M до N = {summa}");
}
if (N < M)
{
    for (int i = N; i <= M; i++)
    {
       summa +=i;
    }
    Console.WriteLine($"Ответ: сумма чисел в промежутке M до N = {summa}");
}

