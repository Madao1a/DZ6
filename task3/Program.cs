// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] CreateMartix(int length, int widht)
{
    Random rand = new Random();
    int [,] matrix = new int[length, widht];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=rand.Next(2,10);
        }
    }
    return matrix;
}

void UpdateMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i%2==0 && j%2==0)
        {
                matrix[i,j]= i*i+j*j;
        }
    }
}
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


int[,] matrix = CreateMartix(length,width);

PrintMatrix(matrix);

/*for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i%2==0 && j%2==0)
        {
                matrix[i,j]= i*i+j*j;
        }
    }*/

UpdateMatrix(matrix);


Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);

