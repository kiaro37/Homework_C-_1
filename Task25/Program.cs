// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



void PrintDegree(int num1, int num2) //принимаем на вход числа A и B
{
    if (num1 > 0 && num2 > 0)
    {
        int count = num1;  //вводим новую переменную
        for (int i = 2; i <= num2; i++)  //счетчик начинаем с 2х, т.к. это минимальная степень для возведения
        {
            count = count * num1;   //возводим число A в степень B        
        }
        Console.WriteLine(count);   // выводим результат    
    }
    else Console.WriteLine("Введены не натуральные числа");
}




Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

PrintDegree(number1, number2);