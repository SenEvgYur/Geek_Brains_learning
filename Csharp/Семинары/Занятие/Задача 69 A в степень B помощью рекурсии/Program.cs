﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 
Console.Clear();
System.Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int Stepen (int a, int b)
{
    if (b < 1) return 1;
    return a * Stepen(a, b-1);
}
Console.WriteLine(Stepen(A, B));
