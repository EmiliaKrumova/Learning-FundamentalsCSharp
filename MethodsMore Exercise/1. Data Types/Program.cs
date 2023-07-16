namespace _1._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondLine = Console.ReadLine();
            
            Console.WriteLine(GetDataType(input, secondLine));

        }
        static string GetDataType(string input, string secondLine)
        {
            string result = string.Empty;
            if(input == "int")
            {
                result = (int.Parse(secondLine)*2).ToString();

            }else if(input == "real")
            {
                double calculation = (double.Parse(secondLine) * 1.5);
                result = ($"{calculation:f2}");

            }else if (input == "string")
            {
                result = ($"${secondLine}$");
            }
            return result;
          // Console.WriteLine(result);   
        }
    }
}