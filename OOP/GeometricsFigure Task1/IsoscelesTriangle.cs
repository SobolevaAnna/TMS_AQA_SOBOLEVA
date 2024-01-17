namespace figur
{
    internal class IsoscelesTriangle : Triangle
    {
            public float A;
            public float B;
            public float C;
            public IsoscelesTriangle(float a, float b, float c)
            {
            A = a;
            B = b;
            C = c;
            TriangleType = "Равнобедренный Треугольник";
        }

        public override float  GetArea()
        {
            if (A == B)
            {
                 return float.Sqrt(4*A*A - C*C)/4;
            }
            else if (B == C)
            {
                 return float.Sqrt(4*B*B - A*A)/4;
            }
            else return float.Sqrt(4*A*A - B*B)/4;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}