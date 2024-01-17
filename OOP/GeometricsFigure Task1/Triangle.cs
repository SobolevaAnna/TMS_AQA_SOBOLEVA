namespace figur
{
    public abstract class Triangle : Figure
    {
        protected string TriangleType { get; set; } = "Не определен";
        protected Triangle() => FigureType = "Треугольник";

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Вид: {TriangleType} \nПлощадь: {GetArea()}");    
        }
    }
}