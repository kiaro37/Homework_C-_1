// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumRows(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[] array = new int[size];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(0)) sum += matrix[i, j];
        }
        array[i] = sum;
        sum = 0;
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int MinIndex(int[] arr)
{
    int minIndexRow = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[minIndexRow] >= arr[i]) minIndexRow = i;
    }
    return minIndexRow;
}

int[,] array2D = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] sumArray = SumRows(array2D);
// PrintArray(sumArray);
// Console.WriteLine();
int min = MinIndex(sumArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min}");
