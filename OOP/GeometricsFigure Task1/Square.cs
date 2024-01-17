namespace figur

{
    internal class Square : Quadrilateral
    {
    public float A;

        public Square(float a)
        {
        A = a;
        QuadrilateralType = "Квадрат";
         if (a <=0)
        {
             throw new Exception("Сторона квадрата не может быть меньше или равна 0");
        };
    }

        public override float GetArea()
        {
            return A * A;
        }       
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}