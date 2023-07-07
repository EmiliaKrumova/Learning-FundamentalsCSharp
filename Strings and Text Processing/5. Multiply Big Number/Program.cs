namespace _5._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // умножение на много голямо число с едноцифрено число, без използване на BigInteger
            string bigNumber = Console.ReadLine();// голямото число като стринг
            int num = int.Parse(Console.ReadLine());// едноцифреното число

            if (num == 0 || bigNumber.All(c => c == '0'))// проверка дали не е подадено невалидно число
            {
                Console.WriteLine("0");
                return;
            }
           
            int[] productArray = new int[bigNumber.Length+1];// масив да пазим произведенията
            for(int i = bigNumber.Length-1; i >=0; i--)// от последния символ в голямото число въртим към първия
            {
                // 3695388955727932769851 3 2 8 4 08

                int currNumber = (bigNumber[i]) - '0';// !! интересен начин без парс да преминем от символ към инт (като извадим символа '0' - > по този начин,чрез ASCII ще получим числото)
                int product = currNumber * num;// произведението (трябва да съобразим, че е възможно да е двуифрено и да има х"наум")

                productArray[i + 1] += product;

                if (productArray[i+1] >9)// ако произведението е над 9 (тоест ако е двуцифрено)
                {
                    productArray[i] += productArray[i + 1] / 10; // на мястото на Единиците поставям остатъка от модулното деление
                    productArray[i+1]  %= 10;// на мястото на Десетиците, поставям цялата част от делението
                }
               
                

            }
            string result = string.Concat(productArray).TrimStart('0');// използвам метода Конкат върху масива от числа, премахвам с ТРИМ ако има водещи (излишни) нули в началото
            Console.WriteLine(result);
        }
    }
}