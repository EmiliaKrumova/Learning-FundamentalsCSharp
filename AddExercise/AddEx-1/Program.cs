using System;

namespace AddEx_1
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
                    Console.WriteLine($"{intValue} is integer type");
                }
                else if (float.TryParse(data, out floatValue))
                {
                    Console.WriteLine($"{floatValue} is floating point type");

                }
                else if (char.TryParse(data, out charValue))
                {
                    Console.WriteLine($"{charValue} is character type");

                }
                else if (bool.TryParse(data, out boolValue))
                {
                    global::System.Console.WriteLine($"{boolValue} is boolean type");
                }
                else
                {
                    global::System.Console.WriteLine($"{data} is string type");
                }


            }
            
        }
    }
}
