// Произведение чисел от 1 до N
Console.Clear();
System.Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int x = 1;
for (int i = 1; i <= N; i++)
{
    Console.Write($"{x} * {i} = ");
    x *= i;
    System.Console.Write(x);
    System.Console.WriteLine();
}
System.Console.WriteLine($"Произведение чисел от 1 до N: {x}");