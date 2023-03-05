int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++) // либо i < rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix; // вернули заполненную таблицу
}

void PrintMatrix(int[,] matr)
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

int countRows(int[,] matr)
{
    int rows = matr.GetLength(0);
    return rows;
}

int countCols(int[,] matr)
{
    int cols = matr.GetLength(1);
    return cols;
}


int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(resultMatrix);
Console.Write(countCols(resultMatrix));
