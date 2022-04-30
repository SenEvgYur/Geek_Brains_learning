// Не используя рекурсию, выведите первые N-чисел Фибоначчи
// Первые чмсла Фибоначчи 0 и 1
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
// int F1 = 0;
// int F2 = 1;
// int Fibonacci = 0;
// for (int i = 0; i < N; i++)
// {
//     Fibonacci = F1 + F2;
//     Console.WriteLine(Fibonacci);
// }

int [] mass = new int[N];
int i = 0;
mass[0] = 0;
mass[1] = 1;
for (i = 2; i < N; i++)
{
    mass[i] = mass[i-2] + mass[i-1];
    System.Console.WriteLine(mass[i] + " ");
}
