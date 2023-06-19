using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                //string numAsStr = (Console.ReadLine());
                int num = int.Parse(command);
                int originalNum = num;
                bool isPalindrome = false;

                int[] reverseNum = new int[command.Length];
                int revercedNumber = ReverseIntegerMetod(ref num, reverseNum);
                if (originalNum == revercedNumber)
                {
                    isPalindrome = true;
                    Console.WriteLine("true");
                }
                else
                {
                    isPalindrome = false;
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }



        }

        private static int ReverseIntegerMetod(ref int num, int[] reverseNum)
        {
            for (int i = 0; i < reverseNum.Length; i++)
            {
                int currDigit = num % 10;
                reverseNum[i] = currDigit;
                num /= 10;
            }
            string recersedNum = String.Empty;
            for (int i = 0; i < reverseNum.Length; i++)
            {
                recersedNum += reverseNum[i];
            }
            int revercedNumber = int.Parse(recersedNum);
            return revercedNumber;
        }
    }
}
