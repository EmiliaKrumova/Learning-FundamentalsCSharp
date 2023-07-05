namespace _4._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new string('*', word.Length));
            //- по този начин може да се създаде нова дума, като се задава като 1-ви параметър от какъв символ ще бъде и 2-ри параметър каква ще е дължината на думата)



            string[] banned = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach( string word in banned )
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}