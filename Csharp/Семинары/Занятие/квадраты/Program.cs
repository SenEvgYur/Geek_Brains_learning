// квадраты
Console.Clear();
Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N = -N;
}
else
{
    int numbers = 1;
    Console.WriteLine("Все квадраты числел с 1 по загаданное число: ");
    while (numbers <= N)
    {
        Console.WriteLine(Math.Pow(numbers, 2));
        numbers++;
    }
}