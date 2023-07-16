namespace _4._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 3)
            {
                for (int i = 1; i <= num; i++)// ако input e 0 - не отпечатва нищо
                    Console.Write($"1 "); // за NUM = 1 и 2 отпечатва единици
            }else if (num >= 3)
            {
                Console.WriteLine(String.Join(" ", Tribonachi(num)));
            }
        }
        static int[] Tribonachi (int num)
        {
            int[] ints = new int[num];// празен масив
            ints[0] = 1; // за числото 1
            ints[1] = 1;// за числото2
            ints[2] = 2; // за числото 3
            for (int i = 3; i < num; i++)// за всички останали числа (сегашното е сбор от предходните 3 в поредицата) 
            {
               
                ints[i] = ints[i - 1] + ints[i - 2] + ints[i-3];

            }
            return ints;

        }
    }
}