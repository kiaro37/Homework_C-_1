// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
if (num > 999)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
}
if (num >= 100 && num <= 999)
{
    int result = num % 10;
    Console.WriteLine($"Третья цифра числа {number} --> {result}");
}
if (num<100)
{
     Console.WriteLine("Третья цифра числа отсутствует");
}