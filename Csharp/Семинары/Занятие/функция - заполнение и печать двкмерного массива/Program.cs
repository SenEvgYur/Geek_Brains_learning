// Функция по заполнению и печати двумерного массива


void PrintArray(int[,] arr)  // функция печати двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void FillArray(int[,] arr) // функция заполнения двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,9);
        }
    }
}

int[,] mas = new int[2, 5];
PrintArray(mas);
FillArray(mas);
PrintArray(mas);