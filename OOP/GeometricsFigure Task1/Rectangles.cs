namespace figur
{
    public class Rectangles : Quadrilateral
    {
    public float A;
    public float B;
        public Rectangles(float a, float b)
        {
        A = a;
        B = b;
        QuadrilateralType = "Прямоугольник";
        if (a <=0 || b <=0)
        {
             throw new Exception("Сторона прямоугольника не может быть меньше или равна 0");
        };
    }
        public override float GetArea()
        {
            return A * B;
        }       
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}
    
