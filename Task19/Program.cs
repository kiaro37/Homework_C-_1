// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    Console.Write($"{number} --> ");
    Console.WriteLine(Palindrome(number) ? "Да" : "Нет");
}
else Console.WriteLine("Число не пятизначное");



bool Palindrome(int num)
{
    if (num / 10000 == num % 10 & num / 1000 % 10 == num / 10 % 10) return true;
    else return false;
}
