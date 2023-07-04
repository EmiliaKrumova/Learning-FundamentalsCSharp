namespace _5._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();// създавам речник с ключ - името на курса и стойност - списък с имената на студентите
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] courseInfo = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = courseInfo[0];
                string student = courseInfo[1];
                if (!courses.ContainsKey(course))// ако този ключ не се съдържа в речника
                {
                    courses[course] = new List<string>();// създавам празен списък
                }
                courses[course].Add(student);// добавям студент в съответният курс
            }
            foreach (var kvp in courses)// взимам всички двойки в речника
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");// принтирам за всеки курс - колко броя студенти има в неговия списък
                foreach(var student in kvp.Value)// вложен цикъл за всеки студент в списъка
                {
                    Console.WriteLine($"-- {student}");// изписвам името на студента
                }
            }
        }
    }
}