// Сумма чисел от 1 до А
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= A; i++)
{
    sum += i;
    System.Console.Write(i + " ");
}

int j = 1;
while (j <= A)
{
    Console.Write(j + " ");
    j++;
}
System.Console.WriteLine();
System.Console.WriteLine(sum);