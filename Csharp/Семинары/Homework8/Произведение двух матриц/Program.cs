// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
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
Console.Write("Введите количество строк в первом и втором массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первом и втором массиве: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(); // визуальный разделитель

Console.WriteLine(); // визуальный разделитель
int[,] massive = new int[m, n]; // объявляем первый массив
int[,] massive1 = new int[m, n]; // объявляем второй массив
int[,] massive2 = new int[m, n]; // объявляем третий (результирующий) массив
FillArray(massive);
Console.WriteLine("Первый массив");
PrintArray(massive);
FillArray(massive1);
Console.WriteLine("Второй массив");
PrintArray(massive1);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massive2[i,j] = massive[i,j]*massive1[i,j];
    }
}
Console.WriteLine("Произведение двух массивов: ");
PrintArray(massive2);