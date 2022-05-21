
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int Rec(int number)
{
    if (number == 0)
    {
        return 0;
    }
    Console.WriteLine(number % 10 + " ");
    return Rec(number / 10) + number % 10;
}
int sum = Rec(number);

Console.WriteLine(sum);