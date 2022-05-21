// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
void Recursion(int n, int i)
{
    if (i > n)
    {
        return;
    }
    Console.Write(i + " ");
    Recursion(n, i + 1);
}
Recursion(N, 1);