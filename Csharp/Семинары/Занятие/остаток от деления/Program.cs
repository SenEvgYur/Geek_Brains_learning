// остаток от деления
Console.Clear();
System.Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if (a % b == 0)
{
   System.Console.WriteLine("кратно");
}
else
{
   System.Console.WriteLine($"остаток от деления: {a % b}");
}