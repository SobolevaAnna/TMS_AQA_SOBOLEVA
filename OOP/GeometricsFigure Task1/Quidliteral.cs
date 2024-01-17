namespace figur
{
    public abstract class Quadrilateral : Figure
    {
        protected string QuadrilateralType { get; set; } = "Не определен";

        protected Quadrilateral() => FigureType = "Четырехугольник";

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(@$"
Вид фигуры: {QuadrilateralType} 
Площадь: {GetArea()}");
        }
    }
}