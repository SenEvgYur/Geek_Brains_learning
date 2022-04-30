// Напишите программу которая будет создавать копию заданного массива, путём поэлементного копирования
int [] arr = new int [5];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);
    System.Console.Write(arr[i] + " ");
}

int [] copy = new int [arr.Length];
for (int i = 0; i < copy.Length; i++)
{
    copy[i] = arr[i];
    System.Console.WriteLine(copy[j] + " ");
}
