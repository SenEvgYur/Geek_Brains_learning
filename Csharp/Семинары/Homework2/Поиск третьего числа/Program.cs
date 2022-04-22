// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет
Console.Clear();
System.Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
// почему-то не даёт сделать число в Int64
if (x < 100 & x > -100)
// работает и &(и) и |(или) 
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    if(x < 0)
    {
        x = -x; 
    }
    while(x.ToString().Length > 3)
    {
        x = x / 10;
    }
    x = x % 10;
    System.Console.WriteLine($"третья цифра: {x}");
}
