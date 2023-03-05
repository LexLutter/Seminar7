double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++) // либо i < rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return matrix; // вернули заполненную таблицу
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // либо i < rows
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] resultMatrix = GetMatrix(3, 4);
PrintMatrix(resultMatrix);
