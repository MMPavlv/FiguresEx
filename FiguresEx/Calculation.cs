using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresEx
{
    public class Figure
    {

    }

    public class Circle : Figure
    {
        public Circle(int r)
        {
            Radius = r;
        }
        public int Radius { get; set; }
    }

    public class Triangle : Figure
    {
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRight()
        {
            return (A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C * B * B == A * A);
        }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
    }

    public class Calculation
    {
        public double CalculateArea<T>(Figure item) where T : Figure
        {
            if (item is Circle)
                return CalculateArea(item as Circle);

            if (item is Triangle)
                return CalculateArea(item as Triangle);

            return CalculateArea(item as T);
        }

        public double CalculateArea(Circle figure)
        {
            if (figure.Radius <= 0)
                throw new ArgumentOutOfRangeException("figure");

            return Math.PI * figure.Radius * figure.Radius;
        }

        public double CalculateArea(Triangle figure)
        {
            if (figure.A + figure.B <= figure.C || figure.A + figure.C <= figure.B || figure.C + figure.B <= figure.A)
                throw new ArgumentOutOfRangeException("figure");

            if (figure.A <= 0 || figure.B <= 0 || figure.C <= 0)
                throw new ArgumentOutOfRangeException("figure");

            double S = (double)(figure.A + figure.B + figure.C) / 2;
            double area = Math.Sqrt(S * (S - figure.A) * (S - figure.B) * (S - figure.C));
            return area;
        }

        public double CalculateArea(Figure figure)
        {
            Console.WriteLine("Unknown Figure");
            return double.NaN;
        }
    }
}
