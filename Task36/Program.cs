// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-50, 50);
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

int SumEvenPosition(int[] arr)
{
    int sum = 0;   //сумма элементов на нечетных позициях
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 == 1)   //проверка позиции на нечетность
        {
            sum = arr[i] + sum;
        }
    }
    return sum;
}



int[] array = CreateArray(7);
PrintArray(array);
Console.WriteLine();
int sum = SumEvenPosition(array);
Console.WriteLine(sum);

