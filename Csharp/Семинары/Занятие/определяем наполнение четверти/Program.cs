// определяем четверть
Console.Clear();
int четверть = new Random().Next (1,4);
System.Console.WriteLine($"четверть = {четверть}");
// int с = Convert.ToInt32(System.Console.ReadLine());

if (четверть == 1)
{
    System.Console.WriteLine("x > 0 и y > 0");
}
else if (четверть == 2)
{
    System.Console.WriteLine("x > 0 и y < 0");
}
else if (четверть == 3)
{
    System.Console.WriteLine("x < 0 и y < 0");
}
else if (четверть == 4)
{
    System.Console.WriteLine("x > 0 и y < 0");
}
