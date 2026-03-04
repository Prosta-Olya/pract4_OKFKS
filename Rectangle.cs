using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pract4_OKFKS
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            string str = Validation(width, height);
            if (str == "")
            {
                Width = width;
                Height = height;
            }
        }

        public string Validation(double width, double height)
        {
            string str = "";
            if (width <= 0 || height <= 0)
            {
                str = "Стороны прямоугольника не могут быть меньше 0 или равны ему";
            }
            return str;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return Width + Width + Height + Height;
        }

        public override string ToString()
        {
            return $"Ширина прямоугольника = {Width} \nВысота прямоугольника = {Height}";
        }
    }
}
