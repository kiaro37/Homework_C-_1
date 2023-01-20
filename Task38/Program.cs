// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

double MaxArrayValue(double[] arr) //находим максимальное значение в массиве
{
    double maxArr = arr[0];   //присваиваем максимальное значение первому элементу
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxArr) maxArr = arr[i];
    }
    return maxArr;
}

double MinArrayValue(double[] arr)   //находим минимальное значение в массиве
{
    double minArr = arr[0];   //присваиваем минимальное значение первому элементу
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minArr) minArr = arr[i];
    }
    return minArr;
}

double[] array = CreateArrayRndDouble(8, 0, 99);
PrintArray(array);
Console.WriteLine();
double maxArray = MaxArrayValue(array);
double minArray = MinArrayValue(array);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива --> {maxArray - minArray}");



