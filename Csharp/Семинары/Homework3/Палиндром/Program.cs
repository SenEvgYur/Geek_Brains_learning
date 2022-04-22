// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x / 10000 == x % 10)
{
    if (x / 1000 % 10 == x / 10 % 10)
    {
        Console.WriteLine("палиндром");
    }
    // если число семизначное или более, то углубляем сюда
    else 
    {
        System.Console.WriteLine("не палиндром");
    }
}
else
{
    System.Console.WriteLine("не палиндром");
}