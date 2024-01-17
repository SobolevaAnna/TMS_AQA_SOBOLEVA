namespace figur
{
    internal static class TriangCreator
    {
        public static Triangle CreateTriangle(float a, float b, float c)
        {
            if (a <=0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Сторона треугольника не может быть меньше или равна 0");
            }

            if ((a + b) <= c || (c + b) <= b || (a + c) <= a)
            {
                throw new Exception(
                    "Заданы некорректные стороны треугольника. Сумма любых двух сторон должна быть больше третьей.");
            }

            if (a == b && a == c)
            {
                return new EquilateralTriangle(a, b, c);
            }

            if (a == b || b == c || a == c)
            {
                return new IsoscelesTriangle(a, b, c);
            }

            if (a*a == (b*b + c*c) || b*b == (a*a + c*c) || c*c == (a*a + b*b))
            {
                return new RectangularTriangle(a, b, c);
            }

            return new VersatileTriangle(a, b, c);
        }
    }
}