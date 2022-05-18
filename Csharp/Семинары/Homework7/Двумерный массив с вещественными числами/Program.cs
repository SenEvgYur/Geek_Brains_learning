// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void PrintArray(double[,] arr)  // функция печати двумерного массива c округлением до тысячных
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(Math.Round(arr[i, j], 3) + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(double[,] arr) // функция заполнения двумерного массива до 100
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble()*100;
        }
    }
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
double[,] massive = new double[m, n]; // объявляем массив
Console.WriteLine("Массив: ");
FillArray(massive);
PrintArray(massive);
