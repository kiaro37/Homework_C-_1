// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double CrossPointX(double a, double b, double c, double d)  //находим координату X
{
    double x = (c - a) / (b - d);
    return x;
}

double CrossPointY(double a, double b, double c, double d)   //находим координату Y
{
    double point = CrossPointX(a, b, c, d);
    double y = b * point + a;
    return y;
}


Console.WriteLine("Введите координаты b1, k1, b2, k2");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double pointX = CrossPointX(b1, k1, b2, k2);
double pointY = CrossPointY(b1, k1, b2, k2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} --> ({pointX}, {pointY})");

