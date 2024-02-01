namespace AbstractClasses.Game
{
    internal class Triangle : Figure
    {
            public double A;
            public double B;
            public double C;
            public double P => (A + B + C) / 2;
            public Triangle(double a, double b, double c)
            {
            A = a;
            B = b;
            C = c;
            FigureType = "Треугольник";
        if (a <=0 || b <=0 || C <= 0)
        {
            throw new Exception("Сторона треугольника не может быть меньше или равна 0");
        };
        }
    
        public override double  GetArea()
        {
            return Math.Round(double.Sqrt(P*(P-A)*(P-B)*(P-C)), 2);
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        public override void PrintInfo()
        {
           //base.PrintInfo();
            Console.WriteLine($"\nВид фигуры: {FigureType}\nПлощадь: {Math.Round(GetArea(), 2)}\nПериметр: {Math.Round(GetPerimeter(), 2)}");
        }
    }
}    
