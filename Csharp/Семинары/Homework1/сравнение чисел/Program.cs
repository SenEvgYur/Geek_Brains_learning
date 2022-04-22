// сравнение чисел
Console.Write("Введите 1-е число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2-е число: ");
double b = Convert.ToDouble(Console.ReadLine());

double max = a;
double min = b;

if (b > a) 
{
    max = b; min = a;
}

Console.WriteLine("Результат сравнения:");
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);