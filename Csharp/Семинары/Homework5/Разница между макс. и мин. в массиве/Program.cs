// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 1001);
    }
}
Console.Clear();
double [] mass = new double[new Random().Next(1, 11)];
FillArray(mass);
PrintArray(mass);
Console.WriteLine();
double min = mass[0];
double max = mass[0];
for (int i = 1; i < mass.Length; i++)
{
    if (mass[i] > max) max = mass[i];
    if (mass[i] < min) min = mass[i];
}
Console.WriteLine($"Ответ: разница между максимальным значением {max} и минимальным значением {min} = {max-min}");