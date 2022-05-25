// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 
Console.Clear();
System.Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
System.Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int Recursion(int a, int b, int n)
{
    if (n == 0) return a;
    if (n == 1) return b;
    return Recursion(a, b, n - 1) + Recursion(a, b, n - 2);
}
for (int i = 0; i < N; i++)
{
    Console.WriteLine(Recursion(A, B, i));
}

// while (N > 0)
// {
//     A = A + B;
//     B = B + A;
//     N = N - 1;
//     Console.WriteLine(A + " " + B + " " + N + "");
// }
