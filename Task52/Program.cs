// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random(); // var когда в правой части ясно какой тип данных мы используем
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],7} ");
        }
        Console.WriteLine("  |");
    }

}

void ColumnsAverage(int[,] matrix)
{
    double sum = 0; //сумма каждого столбца
    double aver = 0; //средняя арифметическая каждого столбца
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (j <= matrix.GetLength(1))
                sum += matrix[i, j];
        }
        aver = sum / matrix.GetLength(0);
        Console.Write($"{aver,7}; ");
        sum = 0;
    }
}


int[,] matrix2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix2D);
Console.WriteLine();
ColumnsAverage(matrix2D);