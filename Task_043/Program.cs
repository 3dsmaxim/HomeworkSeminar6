Console.Clear();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите первое значение b=");
double nunFyrstB = double.Parse(Console.ReadLine());
Console.Write("Введите первое значение k=");
double nunFyrstK = double.Parse(Console.ReadLine());
Console.Write("Введите второе значение b=");
double nunSecondB = double.Parse(Console.ReadLine());
Console.Write("Введите второе значение k=");
double nunSecondK = double.Parse(Console.ReadLine());

Console.Write($"Точка пересечения прямых b и k {CrossPodoubleCoordinate(nunFyrstB, nunFyrstK, nunSecondB, nunSecondK)}");

string CrossPodoubleCoordinate(double FyrstB, double FyrstK, double SecondB, double SecondK)
{
    string cross = "Прямые не пересикаются (паралельны) ";
    double chek = 0;

    string crossT = String.Empty;
    crossT = crossT + $"[{(FyrstB - SecondB) / (SecondK - FyrstK)} | {FyrstK * ((FyrstB - SecondB) / (SecondK - FyrstK)) + FyrstB} ]";
    if (chek != FyrstK * ((FyrstB - SecondB) / (SecondK - FyrstK)) + FyrstB - SecondK * ((FyrstB - SecondB) / (SecondK - FyrstK)) - SecondB) return cross;
    else return crossT;


}