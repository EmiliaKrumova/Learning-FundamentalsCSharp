namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();// дума, която търся
            string text = Console.ReadLine();// произволен текст
            while (text.Contains(word))// докато думата се съдържа в текста
            {
                int indexOfWord = text.IndexOf(word);// необходим ми е индекса, от който започва думата
                text = text.Remove(indexOfWord, word.Length);// трябва да презапиша текста, като премахвам с метода Remove, започвайки от индекса, премахваме дължината на думата
            }
            Console.WriteLine(text);// принтирам новия вариант на текста
        }
    }
}