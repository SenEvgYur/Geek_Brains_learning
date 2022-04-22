// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет,является ли этот день выходным
Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0 & x < 6)
{
    Console.WriteLine("будний день");
}
if (x == 6 | x == 7)
{
    Console.WriteLine("выходной день");
}
if (x > 7 | x < 1)
{
    Console.WriteLine("Введите цифру заново");
}