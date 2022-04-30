// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}
Console.Clear();
int[] mass = new int[new Random().Next(4, 11)];
FillArray(mass);
PrintArray(mass);
Console.WriteLine();
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Ответ: количество чётных элементов в массиве = {count}");