// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()); //записываем в массив числа введенные пользователем
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

int PositiveNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;   //считаем числа больше 0 и записываем количество в результат
    }
    return result;
}




Console.WriteLine("Какое количество чисел вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа через нажатие клавиши Enter");

int[] array = CreateArray(size);
PrintArray(array);

Console.Write(" ---> ");

int sumPositive = PositiveNumbers(array);
Console.WriteLine(sumPositive);


