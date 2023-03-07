int[,] GetMatrix(int rows, int cols, int minValue, int maxValue) // Заполняем двумерный массив
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

void PrintMatrix(int[,] matr) // Выводим на консоль массив
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

void AverageColsMatrix(int[,] matr) // Получаем массив из средне арифмитических элементов в каждом столбце заданного массива
{
    int cols = matr.GetLength(1);
    int rows = matr.GetLength(0);
    double[] matrix = new double[cols];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            matrix[j] = matr[i, j] + matrix[j];
        }
        matrix[j] = matrix[j] / rows;
        // Console.WriteLine($"{matrix[j]}");

    }
    Console.WriteLine($"[ {String.Join(", ", matrix)} ]");
}

int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(resultMatrix);
AverageColsMatrix(resultMatrix);
