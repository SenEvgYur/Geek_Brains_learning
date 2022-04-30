// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
        arr[i] = new Random().Next(0, 11);
    }
}
Console.Clear();
int[] mass = new int[new Random().Next(1, 11)];
FillArray(mass);
PrintArray(mass);
Console.WriteLine();
int sum = 0;
for (int i = 1; i < mass.Length; i = i + 2)
{
    sum += mass[i];
}
Console.WriteLine($"Ответ: сумма чисел на нечётных 'индексах' = {sum}");