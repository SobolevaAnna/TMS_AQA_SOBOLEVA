namespace AbstractClasses.Game
{
    internal class Quadrilateral : Figure
    {
        public double A;
        public double B;

        public Quadrilateral(double a, double b)
        {
        A = a;
        B = b;
        FigureType = "Прямоугольник";

        if (a <=0 || b <=0)
        {
            throw new Exception("Сторона прямоугольника не может быть меньше или равна 0");
        };
        }
        
        public override double  GetArea()
        {
            return A*B;
        }

        public override double  GetPerimeter()
        {
            return 2*(A + B);
        }
        
        public override void PrintInfo()
        {
            //base.PrintInfo();
            Console.WriteLine($"\nВид фигуры: {FigureType}\nПлощадь: {Math.Round(GetArea(), 2)}\nПериметр: {Math.Round(GetPerimeter(), 2)}");
        }
    }
}