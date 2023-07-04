namespace _6._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < count; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(student))
                {
                    students[student] = new List<double>();
                }
                students[student].Add(grade);

            }
            foreach(var kvp in students)
            {
                double avrGrade = kvp.Value.Average(x => x);
                if (avrGrade < 4.50)
                {
                    students.Remove(kvp.Key);
                }else
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average(x => x):f2}");
                }
                
            }
        }
    }
}