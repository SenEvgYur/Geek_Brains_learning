// Напишите программу, которая принимает нна вход 3 числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины
Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int C = int.Parse(Console.ReadLine());
if (A < B + C && B < C + A && C < A + B)
{
    Console.WriteLine("Ответ: такой треугольник может существовать");
} 
else 
{
    Console.WriteLine("Ответ: такой треугольник не может существовать");
}