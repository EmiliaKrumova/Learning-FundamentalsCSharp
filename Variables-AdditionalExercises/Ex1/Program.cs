using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int intValue;
            float floatValue;
            char charValue;
            bool boolValue;
            while (data != "END")
            {
                if (int.TryParse(data, out intValue))
                {
                    Console.WriteLine($"{data} is integer type");
                }
                else if (float.TryParse(data, out floatValue))
                {
                    Console.WriteLine($"{data} is floating point type");

                }
                else if (char.TryParse(data, out charValue))
                {
                    Console.WriteLine($"{data} is character type");

                }
                else if (bool.TryParse(data, out boolValue))
                {
                    global::System.Console.WriteLine($"{data} is boolean type");
                }
                else
                {
                    global::System.Console.WriteLine($"{data} is string type");
                }
                data= Console.ReadLine();


            }
        }
    }
}
