using System;

namespace _01._Random_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] names = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessages = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < numberOfMessages; i++)
            {
                string phrase = phrases[random.Next(phrases.Length)];
                string evens = events[random.Next(events.Length)];
                string name = names[random.Next(names.Length)];
                string city = cities[random.Next(cities.Length)];

                Console.WriteLine($"{phrase} {evens} {name} – {city}.");
            }

        }
    }
}
