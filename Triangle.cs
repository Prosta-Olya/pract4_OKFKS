using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4_OKFKS
{
    public class Triangle : Shape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            string str = Validation(sideA, sideB, sideC);
            if(str == "")
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
        }

        public string Validation(double sideA, double sideB, double sideC)
        {
            string str = "";
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                str = "Стороны треугольника не могут быть меньше 0 или равны ему";
                return str;
            }
            if (sideA > sideB + sideC)
            {
                str = "Сторона А имеет некорректное значение";
                return str;
            }
            if (sideB > sideA + sideC)
            {
                str = "Сторона B имеет некорректное значение";
                return str;
            }
            if (sideC > sideB + sideA)
            {
                str = "Сторона C имеет некорректное значение";
                return str;
            }
            return str;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt((p * (p - SideA) * (p - SideB) * (p - SideC)));
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override string ToString()
        {
            return $"Стороны треугольника: A = {SideA}, B = {SideB}, C = {SideC}";
        }
    }
}
