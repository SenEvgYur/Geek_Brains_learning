// координаты точки
Console.Clear();
System.Console.Write("Введите число x: ");
int x = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число y: ");
int y = Convert.ToInt32(System.Console.ReadLine());

if (x > 0 & y > 0)
{
    System.Console.WriteLine("точка в 1-й четверти");
}
if (x < 0 & y > 0)
{
    System.Console.WriteLine("точка в 2-й четверти");
}
if (x < 0 & y < 0)
{
    System.Console.WriteLine("точка в 3-й четверти");
}
if (x > 0 & y < 0)
{
    System.Console.WriteLine("точка в 4-й четверти");
}
if (x == 0 | y == 0)
{
    System.Console.WriteLine("не принадлежит конкретной четверти");
}
