using System;

namespace Lab9_Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();// прочитам какъв вид ще са променливите
            string firstValue = Console.ReadLine();// първа променлива
            string secondValue = Console.ReadLine(); // втора 
            if (type == "int")// ако са от тип инт
            {

                int first = int.Parse(firstValue);// парсвам към инт
                int second = int.Parse(secondValue);
                int result = GetMax(first, second); // взимам от инт метода
                Console.WriteLine(result);
            } 
            
            else if (type == "char") // ако са символи
            {

                char a = char.Parse(firstValue);// парсвам
                char b = char.Parse(secondValue);
                char result = (char) GetMax(a, b);// взимам си метод за символи - кастнат към char
                Console.WriteLine(result); 
            }else if (type== "string")// ако е тип стринг
            {

                string result = GetMax(firstValue, secondValue);// метод за стринг
                Console.WriteLine(result);

                    
            }

            
        }
        static int GetMax(int a, int b)// метод за инт
        {


            if (a > b)// ако а >б
            {
                return a;// върни резултат а
            }
            else

                return b;// иначе, върни б

        }

        static char GetMax(char a, char b)// метод за символи
        {
            if (a > b)
            {
                return a;
            }
            else

                return b;

        }
        static string GetMax(string a, string b)// метод за стринг
        {
            int result = a.CompareTo(b);// стринг а сравнен със стринг б, ще даде положително число ако а е по-голям, 0 - ако са равни двата стринга, и отрицателно число ако втория стринг е по-голям.
            if (result > 0)// ако резултата е над 0, означава, че първия стринг е по-голям
                return a;
            else return b;
        }
    }
}
