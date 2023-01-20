// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
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

int EvenNumbers(int[] arr)
{
    int count = 0;   //счетчик четных чисел
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] % 2 == 0) //условие нахождения четных чисел в массиве
        {
        count++;
        }
    }
    return count;
}



int[] array = CreateArray(4);
PrintArray(array);
Console.WriteLine();
int result = EvenNumbers(array);
Console.WriteLine (result);