namespace _5._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSign(firstNumber, secondNumber, thirdNumber));

        }
        public static string GetSign(int firstNumber, int secondNumber, int thirdNumber)
        {
            string result = string.Empty;
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                result = "zero";
                return result;
            }
            result = PositiveOrNegative(firstNumber, secondNumber, thirdNumber);
            return result;
        }

        private static string PositiveOrNegative(int firstNumber, int secondNumber, int thirdNumber)
        {
            string result;
            int countNegatives = 0;
            if (firstNumber < 0)
            {
                countNegatives++;
            }
            if (secondNumber < 0)
            {
                countNegatives++;
            }
            if (thirdNumber < 0)
            {
                countNegatives++;
            }
            if (countNegatives % 2 == 0)
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }

            return result;
        }
    }
}