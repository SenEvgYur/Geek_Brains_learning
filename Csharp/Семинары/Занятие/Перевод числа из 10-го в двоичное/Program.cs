// Напишите программу, которая будет принимать на вход число и 
// пеереводить его в двоичное
Console.Clear();
Console.Write("Ведите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
int A = int.Parse(Console.ReadLine());
int B = 0;
string C = String.Empty;
while (A > 0)
{
    B = A % 2;
    A = A / 2;
    C = (B.ToString() + C);
}
Console.WriteLine(C);

// int D = int.Parse(C);
// Console.WriteLine(D);
