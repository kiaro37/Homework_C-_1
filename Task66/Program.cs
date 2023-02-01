// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {numberM}; N = {numberN} --> {SumMinToMax(numberM, numberN)}");





int SumMinToMax(int m, int n)
{
    if (m < 0) m = 0;
    {
        if (n < 0) n = 0;
        {
            if (m < 0 && n < 0) return n;
            {
                if (m > n)
                {
                    if (m == n) return n;
                    return SumMinToMax(m - 1, n) + m;
                }
                if (m < n)
                {
                    if (m == n) return n;
                    return SumMinToMax(m + 1, n) + m;
                }
                else return n;
            }
        }
    }
}
