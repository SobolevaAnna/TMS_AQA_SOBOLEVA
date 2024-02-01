namespace AbstractClasses.Game
{
    public abstract class Figure
    {
        public string FigureType { get; set; } = "";
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void PrintInfo();

    }
}