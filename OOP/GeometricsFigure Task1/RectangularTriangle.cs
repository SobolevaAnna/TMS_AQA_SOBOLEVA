namespace figur
{
    internal class RectangularTriangle : Triangle
    {
            public float A;
            public float B;
            public float C;
            public RectangularTriangle(float a, float b, float c)
            {
            A = a;
            B = b;
            C = c;
            TriangleType = "Прямоугольный Треугольник"
            ;
        }

        public override float  GetArea()
        {

            if (A> B && A > C)
            {
                 return B*C/2;
            }
            else if (B> A && B > C)
            {
                 return A*C/2;
            }
            else return B*A/2;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}
