﻿// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B
Console.Clear();
System.Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
// System.Console.WriteLine($"Число {A} в степени {B}:")
// System.Console.WriteLine(Math.Pow(A, B));
// самое короткое решение
int C = A;
for (int i = 1; i < B; i++)
{
    C = C * A;
}
System.Console.WriteLine($"Ответ: {A} в степени {B} = {C}");
