using System;
using System.Text;

namespace _1._Encrypt__Sort__and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStrings = int.Parse(Console.ReadLine());
            //int[] sumOfChars= new int[countOfStrings];
            int[] sums = new int[countOfStrings];
            for (int i = 0; i < countOfStrings; i++)
            {
                string currentName = Console.ReadLine();
                int currNameLength = currentName.Length;
                string substringVowels = String.Empty;
                string substringConsonants = String.Empty;
                int sumOfVowels = 0;
                double sumOfConsonants = 0;
                int curentSumOfAllchars = 0;
                for (int firstChar = 0; firstChar < currNameLength; firstChar++)
                {
                    char currentChar = currentName[firstChar];
                    if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' || currentChar == 'A' || currentChar == 'E' || currentChar == 'I' || currentChar == 'O' || currentChar == 'U')
                    {
                        substringVowels += currentChar;
                        sumOfVowels += currentChar * currNameLength;
                    }
                    else
                    {
                        substringConsonants += currentChar;
                        sumOfConsonants += currentChar / currNameLength;
                    }


                }
                curentSumOfAllchars = sumOfVowels + (int)sumOfConsonants;
                sums[i] = curentSumOfAllchars;


            }
            Array.Sort(sums);
            for (int k = 0; k < sums.Length; k++)
            {
                Console.WriteLine(sums[k]);
            }
        }
    }
}
