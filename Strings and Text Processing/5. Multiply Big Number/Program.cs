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
                     //(в стринга проверявам дали не е целия стринг с нули -> за всеки символ дали не е '0')
            {
                Console.WriteLine("0");
                return;
            }
           
            int[] productArray = new int[bigNumber.Length+1];// масив да пазим произведенията
            for(int i = bigNumber.Length-1; i >=0; i--)// от последния символ в голямото число въртим към първия
            {
                

                int currNumber = (bigNumber[i]) - '0';// !! интересен начин без инт.парсе да преминем от символ към инт
                                                      // (като извадим символа '0' - > по този начин,чрез ASCII ще получим числото)


                int product = currNumber * num;// произведението (трябва да съобразим, че е възможно да е двуифрено и да има х"на ум")

                productArray[i + 1] += product;// тук индекса е +1, защото масива е с дължина - дължината на голямото чисто +1 и има отместване с един индекс

                if (productArray[i+1] >9)// ако произведението е над 9 (тоест ако е двуцифрено)
                {
                    productArray[i] += productArray[i + 1] / 10; // на мястото на Десетиците, поставям цялата част от делението
                    productArray[i+1]  %= 10;// на мястото на Единиците поставям остатъка от модулното деление

                }



            }
            string result = string.Concat(productArray).TrimStart('0');// използвам метода Конкат върху масива от числа, премахвам с ТРИМ ако има водещи (излишни) нули в началото
            Console.WriteLine(result);
        }
    }
}