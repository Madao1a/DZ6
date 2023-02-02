// Показать двумерный массив размером m×n заполненный вещественными числами

int[,] CreateMatrix(int length, int width, int left, int right)
{
    Random rand= new Random();
    int[,] matrix = new int [length, width];
    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(left,right);
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

int ReadInt(string massage)
{
    Console.Write(massage);
    return int.Parse(Console.ReadLine()!);
}

int length = ReadInt("Enter amount of rows m: ");
int width = ReadInt("Enter amount of columns n: ");
int left = ReadInt("Enter left side elements: ");
int right = ReadInt("Enter right side elements: ");

int[,] matrix = CreateMatrix(length,width,left, right);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
