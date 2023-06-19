using System;

namespace Lab6_Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double higthOfTriangle = double.Parse(Console.ReadLine());
            double area = RectangleArea(sideA, higthOfTriangle);
            Console.WriteLine(area);

        }
        static double RectangleArea (double sideA, double higthOfTriangle)
        {
            return sideA * higthOfTriangle;
        }
    }
}
