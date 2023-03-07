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

void PrintMatrix(int[,] matr) // Выводим в консоль массив
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

int CountRows(int[,] matr) // Считаем количество строк и возвращаем число
{
    int rows = matr.GetLength(0);
    return rows;
}

int CountCols(int[,] matr) // Считаем количество столбцов и возвращаем число
{
    int cols = matr.GetLength(1);
    return cols;
}

void FindElementMatrix(int rows, int cols, int[,] matr) // Проверяем есть ли в таблице заданный элемент, если есть, то выводим его
{
    if (rows > 0 && rows <= CountRows(matr) && cols > 0 && cols <= CountCols(matr)){
        Console.Write("Заданный элемент присутствует в таблице и его значение равно: " + matr[rows-1, cols-1]);
    }
    else Console.Write("Заданный элемент отсутствует в таблице");
}

int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(resultMatrix);
FindElementMatrix(0, 3, resultMatrix);