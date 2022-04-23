// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве
Console.Clear();
int x1 = 4;
int y1 = 6;
int x2 = 5;
int y2 = 9;
int x3 = 9;
int y3 = 8;

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(x3 - y3, 2));
// можно округлить через Math.Round(Double, Int32),
// где Double - это само число с плавающей запятой,
// а Int32 - количество разрядов после запятой
System.Console.WriteLine(length);
