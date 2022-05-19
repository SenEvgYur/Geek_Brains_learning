// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void PrintArray(int[,] arr)  // функция печати двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int[,] arr) // функция заполнения двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());
int[,] massive = new int[m, n]; // объявляем массив
FillArray(massive);
PrintArray(massive);
Console.Write("Введите индекс строки в массиве: "); // запрашиваем у пользователя индекс строки
int m1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца в массиве: "); // запрашиваем у пользователя индекс столбца
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
if (m1 >= 0 && m1 <= m - 1) // задаём первую проверку на индекс строки
{
    if (n1 >= 0 && n1 <= n - 1) // задаём вторую проверку на индекс столбца
    {
        Console.WriteLine($"Ответ: искомое число = {massive[m1, n1]}");
    }
}
else Console.WriteLine($"Ответ: нет числа с таким индексом");