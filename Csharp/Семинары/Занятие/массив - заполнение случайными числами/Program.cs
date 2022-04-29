// массив из 8 элементов 
Console.Clear();
int []mas = new int[8];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next (0, 2);
    Console.Write(mas[i] + " ");
}
System.Console.WriteLine(" ");