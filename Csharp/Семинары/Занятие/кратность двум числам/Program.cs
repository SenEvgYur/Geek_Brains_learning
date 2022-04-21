// кратность двум числам
Console.Clear();
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(System.Console.ReadLine());

int b = 7;
int c = 23;

if ((a % b == 0) & (a % c == 0))
{
   System.Console.WriteLine($"кратно {b} или {c}");
}
else
{
   System.Console.WriteLine($"не кратно {b} или {c}");
}