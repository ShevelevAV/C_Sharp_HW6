/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double coordX(double a, double b, double c, double d)
{
    double f = -(b - d) / (a - c);
    return f;
}
double coordY(double v, double n, double m)
{
    double s = v * m + n;
    return s;
}

Console.WriteLine("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine()!);
double x = coordX(k1, b1, k2, b2);
double y = coordY(k2, b2, x);
Console.WriteLine($"{x},{y}");
