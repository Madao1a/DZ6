// В матрице чисел найти сумму элементов главной диагонали (не понятно, что делать если матрица не квадратная)
int[,] CreateMartix(int length, int widht)
{
    Random rand = new Random();
    int [,] matrix = new int[length, widht];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(1,10);
        }
    }
    return matrix;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void UpdateMatrix(int[,] matrix)
{
    int sum=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j)
            {
                sum=sum+ matrix[i,j];
            }
        }
    }
    Console.WriteLine ("Sum= "+ sum);
}

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return int.Parse(Console.ReadLine()!);
}
 
int length = ReadInt("Enter amount of rows m: ");
int width = ReadInt("Enter amount of columns n: ");

int[,] matrix = CreateMartix(length,width);
PrintMatrix(matrix);
UpdateMatrix(matrix);