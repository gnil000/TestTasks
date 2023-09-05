namespace FigureLibrary
{
    public class Figure
    {

        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRightTriangle(double a, double b, double c)
        {
            double[] arr = { a, b, c };
            Array.Sort(arr);
            double sideA = arr[2];
            double sideB = arr[1];
            double sideC = arr[0];
            if ((sideA * sideA) == ((sideB * sideB) + (sideC * sideC)))
                return true;
            return false;
        }

    }
}