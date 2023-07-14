using System.Text.RegularExpressions;

namespace _6._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(?<user>([A-Za-z0-9]+([_\-\.]?)*\w+))@(?<host>[A-Za-z]+(\-*[A-Za-z]+)(\.+[A-Za-z]+)+)";
            //(^|(?<=\s)) - Това проверява дали стринга е в началото и няма излишни символи преди групата user
            //(ЗАДЪЛЖАВА ДА ИМА СПЕЙС И НИЩО ДРУГО ПРЕД ДУМАТА)

            //(?<user>([A-Za-z0-9]+([\_\-\.])*?\w+)) група за потребителското име
            //(Може да съдържа букви, цифри и "_"  долна черта  '-'  тире или '.'точка между тях)
            //Затова след тези символи задължително трябва да има има отново \w, защото не може с тях да завършва думата

            //после @

            // (?<host>[A-Za-z]+(\-*[A-Za-z]+) първа част на хоста, може да има букви, разделени с тире
            //(\.+[A-Za-z]+) задължително поне една точка и букви
            //(?<host>[A-Za-z]+(\-*[A-Za-z]+)(\.+[A-Za-z]+)+) цялата група завършва с + защото може да има хост с два домейна aaa@hhh.kklll.com

            Regex emailPattern = new Regex(pattern);
            MatchCollection emails = emailPattern.Matches(input);
            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}