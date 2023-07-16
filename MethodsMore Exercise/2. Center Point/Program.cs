namespace _2._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            GetShorterDistance(x1, y1, x2, y2);

        }// a2+b2=c2

        private static void GetShorterDistance(double x1, double y1, double x2, double y2)
        {
            double distance1 = HypotenusePitagor(x1, y1);
            double distance2 = HypotenusePitagor(x2, y2);
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double HypotenusePitagor(double x, double y)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);
            return hypotenuse;
        }
    }
}