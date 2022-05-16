// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
int[,] massive = new int[m, n];
FillArray(massive);
PrintArray(massive);
int summa;
double averageColumns;
for (int i = 0; i < massive.GetLength(0); i++)
{
    summa = 0;
    averageColumns = 0;
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        summa += massive[j, i];   
    }
    averageColumns = summa/m;
    Console.Write($"Среднее значение столбца под индексом {i} равно {averageColumns}");
    Console.WriteLine();
}