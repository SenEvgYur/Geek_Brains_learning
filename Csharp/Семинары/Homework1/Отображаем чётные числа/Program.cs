// Отображаем чётные числа
Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbers = 1;

Console.Write("Все чётные числа с 1 по загаданное число: ");

while (numbers <= N) 
{
    if (numbers % 2 == 0)
    {
        Console.Write($"{numbers}  ");
    }
    numbers++;
}
