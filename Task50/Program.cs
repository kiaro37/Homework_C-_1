// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет


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

void SearchElement(int[,] matrix)
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (a < matrix.GetLength(0) && b < matrix.GetLength(1) && a >= 0 && b >= 0) //Проверка на отрицательные числа и вхождение в размер массива
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (a == i && b == j) Console.WriteLine($"{a},{b} --> {matrix[i, j]}"); //Вывод искомого числа
            }
        }
    }
    else Console.WriteLine($"{a},{b} --> Такого элемента в массиве нет"); 
}



int[,] matrix2D = CreateMatrixRndInt(4, 8, -10, 10);
PrintMatrix(matrix2D);
Console.WriteLine();
Console.WriteLine("Введите координаты искомого элемента: ");
Console.WriteLine();
SearchElement(matrix2D);