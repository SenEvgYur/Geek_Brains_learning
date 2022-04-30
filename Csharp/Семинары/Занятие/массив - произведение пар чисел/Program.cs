// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Clear();
int[] mass = new int[5];
int[] result = new int[(mass.Length + 1) / 2];
// Print (mass);
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 10);
}
Print(mass);
result[result.Length - 1] = mass[mass.Length / 2];
for (int i = 0; i < mass.Length / 2; i++)
{
    result[i] = mass[i] * mass[mass.Length - 1 - i];
}
Print(result);


