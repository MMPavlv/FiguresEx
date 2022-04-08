using System;

namespace FiguresEx
{
    class Program
    {
        void Run()
        {
            Calculation calc = new Calculation();
            Circle c = new Circle(10);
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine(calc.CalculateArea<Circle>(c));
            Console.WriteLine(calc.CalculateArea<Triangle>(t));
            Console.WriteLine(t.IsRight());
        }

        static void Main(string[] args)
        {
            new Program().Run();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
