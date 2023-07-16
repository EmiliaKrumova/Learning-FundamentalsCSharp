namespace _3._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());// получаваме 2 двойки точки в координатна система, между всяка двойка се чертае права. Коя права линия е по-дълга?
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void GetLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            // в координатната система използвам Питагоровата теорема, а за да намеря дължината на катетите изваждам симетрично х точките и у точките (ако са положително и отрицателно число катета става по-дълъг (+3-(-5) = -8)
            double katetA = x1 - x2;
            double katetB = y1 - y2;
            double katetC = x3 - x4;
            double katetD = y3 - y4;
            double distance1 = HypotenusePitagor(katetA, katetB);// определям дължината на правата - която е диагонал на правоъгълник или хипотенуза на правоъгълен триъгълник
            double distance2 = HypotenusePitagor(katetC, katetD);

            if (distance1 >= distance2)
            {
                GetShorterDistance(x1, y1, x2, y2);
                
            }
            else
            {
                GetShorterDistance(x3, y3, x4, y4);
                
            }
        }

        private static void GetShorterDistance(double x1, double y1, double x2, double y2)// при вече определена коя права линия е по-дълга, трябва да проверя отново с потагоровата теорема, коя от двете точки (начало и край на правата) е по-близо до центъра на координатната система)
        {
            double distance1 = HypotenusePitagor(x1, y1);
            double distance2 = HypotenusePitagor(x2, y2);
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        static double HypotenusePitagor(double x, double y)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);
            return hypotenuse;
        }
    }
}