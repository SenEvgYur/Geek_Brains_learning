// Задача 51. Сумма чисел в главной диагонали
Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 9);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int result = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i == j)
        {
            mass[i, j] = mass[i, j] + mass[i, j];
            result = result + mass[i, j];
        }
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
System.Console.WriteLine();
Console.WriteLine($"Ответ: сумма элементов с одинаковым индексом равна: {result}");

// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0; j < mass.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             mass[i, j] = mass[i, j] + mass[i, j];
//         }
//         Console.Write(mass[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

