// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
// Console.Write("Введите число A: ");
// string A = Console.ReadLine();
// for (int i = 0; i < A.Length; i++)
// {
//     [i]A = int.Parse(A[i]);
//     Console.Write(B[i] + " ");
// }
int A = int.Parse(Console.ReadLine());
int B = A%10;
int C = 0;
int sum = 0;
while (A / 10 > 0)
{
    A = A / 10;
    C = A % 10;
    sum += C;
}
System.Console.WriteLine();
System.Console.WriteLine($"Ответ: сумма цифр в числе: {sum + B}");