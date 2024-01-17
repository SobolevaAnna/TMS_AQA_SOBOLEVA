namespace figur
{
    internal class VersatileTriangle : Triangle
    {
            public float A;
            public float B;
            public float C;
            public float P => (A + B + C) / 2;
            public VersatileTriangle(float a, float b, float c)
            {
            A = a;
            B = b;
            C = c;
            TriangleType = "Разносторонний Треугольник";
        }

        public override float  GetArea()
        {
            return float.Sqrt(P*(P-A)*(P-B)*(P-C));
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}