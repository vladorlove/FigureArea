using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigAreasLib
{
    public class FigAreas
    {
        // Площадь окружности
        public double CircleArea(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }

        // Площадь треугльника
        public double TriangleArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2; // вычисляем полупериметр треугольника
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // площадь треугольника по ф-ле Герона
            if ((a*a + b*b == c*c)||(b*b + c*c == a*a)||(c*c + a*a == b*b)) // проверка на "прямоугольность" простым сравнением квардратов сторон
                Console.WriteLine("Треугольник прямоугольный");
            return S;
        }
    }
}
