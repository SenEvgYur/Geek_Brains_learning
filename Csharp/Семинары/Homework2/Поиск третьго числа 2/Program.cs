// Поиск третьего числа
Console.Clear();
System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a /100 ==0)
{
    System.Console.WriteLine("Третьей цифры в заданном числе нет");
}
else
{
    while (a / 1000 > 0)
    {
        a = a / 10;
    }
    System.Console.WriteLine($"Третья цифра в заданном числе: {a % 10}");
}