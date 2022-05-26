// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
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

int Sum(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum += arr[m, n];
                minSum += arr[m, n]; 
            }
            else sum += arr[m, n]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = m;
        }
        sum = 0;
    }
    return minNum;
}
Console.WriteLine();
Console.WriteLine("Ответ: наименьшая сумма элементов в строке с индексом " + Sum(massive));