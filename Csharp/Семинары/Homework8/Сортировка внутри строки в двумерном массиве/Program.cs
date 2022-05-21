// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
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
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[,] massive = new int[m, n]; // объявляем массив
FillArray(massive);
PrintArray(massive);
int temp; // вводим временную переменную для сортировки
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n-1; j++)
    {
        temp = massive[i, j];
        if (massive[i, j] > massive[i, j+1])
        {
            massive[i, j] = massive[i, j+1];
            massive[i, j+1] = temp;
        }
    }
}
PrintArray(massive);