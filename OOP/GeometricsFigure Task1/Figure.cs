namespace figur
{
    public abstract class Figure
    {
        public string FigureType { get; set; } = "";
        public abstract float GetArea();
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Тип фигуры: {FigureType}");
        }
    }
}

