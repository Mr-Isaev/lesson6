/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.WriteLine("Прямая 1. Введите a1");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 1. Введите b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 2. Введите a2");
double a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 2. Введите b2");
double b2 = double.Parse(Console.ReadLine());



void Crossingrights(double a1, double a2, double b1, double b2)
{
    if (a1 != a2)
    {
        double x = (b1 - b2) / (a2 - a1);
        double y = a1 * x + b1;
        Console.Write($"x = {x} y1 = {y}");
    }
    else if (a1 == a2 && b1 != b2)
    {
        Console.Write("Две прямые параллельные");
Crossingrights(a1,a2,b1,b2);
	 }
}