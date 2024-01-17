namespace figur
{
    internal class EquilateralTriangle : Triangle
    {
            public float A;
            public float B;
            public float C;
            public EquilateralTriangle(float a, float b, float c)
            {
            A = a;
            B = b;
            C = c;
            TriangleType = "Равносторонний Треугольник";
        }

        public override float  GetArea()
        {

        return float.Sqrt(3)*A*A/4;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}