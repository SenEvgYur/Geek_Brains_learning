// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве
Console.Clear();
int x1 = 3;
int y1 = 6;
int x2 = 4;
int y2 = 2;
int x3 = 7;
int y3 = 6;

double length = Math.Sqrt(Math.Pow(x1-x2-x3,2) + Math.Pow(y1-y2-y3,2));
// можно округлить через Math.Round(Double, Int32),
// где Double - это само число с плавающей запятой,
// а Int32 - количество разрядов после запятой
System.Console.WriteLine(length);
