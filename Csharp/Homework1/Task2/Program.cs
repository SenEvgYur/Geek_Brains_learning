// Максимальное из 3-х чисел
Console.Write("Введите 1-е число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2-е число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 3-е число: ");
double c = Convert.ToDouble(Console.ReadLine());

double max = a;
double min = b;

if (b > a) 
{
    max = b; min = a;
}
if (c > max)
{
    max = c;
}
if  (c < min)
{
    min = c;
}

Console.WriteLine("Результат сравнения:");
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
