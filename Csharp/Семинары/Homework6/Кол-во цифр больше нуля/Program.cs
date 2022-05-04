// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Введите любое количество цифр через пробел:");
string M = Console.ReadLine();
int count = 0;
string[] mass = M.Split(" ");
for (int i = 0; i < mass.Length; i++)
{
    int some  = int.Parse(mass[i]);
    if (some > 0) count++;
}
System.Console.WriteLine($"Ответ: количество цифр больше нуля = {count}");