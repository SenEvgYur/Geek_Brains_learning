// сравнение цифр в заданном диапазоне числа
int a = new Random().Next(10, 100);
System.Console.WriteLine($"число {a}");

int b = a / 10;
int c = a % 10;

if (b > c)
{
    System.Console.WriteLine($"бОльшее число {b}");
}
else
{
    System.Console.WriteLine($"бОльшее число {c}");
}