// See https://aka.ms/new-console-template for more information
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
int min=matrix[0,0];
int mini=0;
int minj=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j]<min)
        {
            min=matrix[i,j];
            mini=i;
            minj=j;
        }
    }
}
int[,] newmatrix=new int [m-1,n-1];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i!=mini & j!=minj)
        {
            int a=i, b=j;
            if (i>mini) a--;
            if (j>minj) b--;
            newmatrix[a,b]=matrix[i,j];            
        }
    }
}
Console.WriteLine();
PrintArray(newmatrix);

