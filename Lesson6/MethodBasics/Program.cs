// See https://aka.ms/new-console-template for more information
using MethodBasics;

PrintString("Hello, World!", ConsoleColor.Cyan);
PrintString("Hello, World!");

double radius = 5.2;
double area = CalculateCircleArea(radius);
Console.WriteLine($"The area of a circle with radius {radius:0.000} is {area:0.000}.");

Console.WriteLine($"The area of a circle with radius {radius:0.000} is {CalculateCircleArea(radius):0.000}.");

area = MathStuff.CalculateCircleArea(radius);
Console.WriteLine($"The area of a circle with radius {radius:0.000} is {area:0.000}.");

double cir = MathStuff.CalculateCircleCircumference(radius);
Console.WriteLine($"The circumference of a circle with radius {radius:0.000} is {cir:0.000}.");


void PrintString(string str, ConsoleColor color = ConsoleColor.Gray)
{
    ConsoleColor original = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.WriteLine(str);
    Console.ForegroundColor = original;

    // return;  not required
}

//void PrintString(string str)
//{
//    Console.WriteLine(str);
//}

double CalculateCircleArea(double radius)
{
    double area = Math.PI * radius * radius;
    return area;
}