// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; 5,5) - тут ошибка, получается (-0,5; -0,5)
Console.Clear();
Console.Write("Введите координату b1 для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k1 для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b2 для второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k2 для второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x;
double y;
// y = k1*x + b1, y = k2*x + b2
// k1*x + b1 = k2*x + b2
// k1*x + b1 - b2  = k2*x
// b1 - b2 = k2*x - k1*x
// (b1 - b2) = x (k2 - k1)
// x (k2 - k1) = (b1 - b2)
// x = (b1 - b2)/ (k2 - k1)
x = (b1 - b2) / (k2 - k1);
// y = k1*x + b1    из условия
y = k1*x + b1;
// b1 = 2, k1 = 5, b2 = 4, k2 = 9
Console.WriteLine();
Console.WriteLine($"Ответ: точка пересечения двух прямых ( x = {x} ; y = {y} )");