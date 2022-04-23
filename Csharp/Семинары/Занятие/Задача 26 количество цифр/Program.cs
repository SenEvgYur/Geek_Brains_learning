// принимает на вход число и считает количество цифр
Console.Clear();
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x < 0)
{
    x = -x;
}
int l = x.ToString().Length;
Console.WriteLine($"количество цифр в заданном числе: {l}");
