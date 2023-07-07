namespace _3._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            int indexOfSlash = input.LastIndexOf(@"\");
            int indexOfDot = input.LastIndexOf(".");
            string fileName = input.Substring(indexOfSlash+1, (indexOfDot-1)-indexOfSlash);
            string extention = input.Substring(indexOfDot+1,input.Length-(indexOfDot+1));


            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}