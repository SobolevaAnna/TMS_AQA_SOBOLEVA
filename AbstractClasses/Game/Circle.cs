namespace AbstractClasses.Game
{
    internal class Circle : Figure
    {
        public double R;
        public Circle(double r)
        {
        R = r;
        FigureType = "Круг";
        if (r <=0)
        {
             throw new Exception("Радиус круга не может быть меньше или равна 0");
        };
    }
        public override double GetArea()
        {
            return Math.PI*R*R;
        }       

        public override double GetPerimeter()
        {
            return 2*Math.PI*R;
        } 

        public override void PrintInfo()
        {
            //base.PrintInfo();
            Console.WriteLine($"\nВид фигуры: {FigureType}\nПлощадь: {Math.Round(GetArea(), 2)}\nПериметр: {Math.Round(GetPerimeter(), 2)}");
        }
    }
}