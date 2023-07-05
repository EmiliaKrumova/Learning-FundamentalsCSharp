namespace _1._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, string> courses = new Dictionary<string, string>();

            command = AddNewCourse(courses);// метод за създаване на нов курс и записване в речника "Курсове"     
                     
            // нов речник за всеки студент (Студент, <Курс, Точки>)
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            string userTokens;
            while ((userTokens = Console.ReadLine()) != "end of submissions")
            {
                string[] userArgs = userTokens.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = userArgs[0];
                string password = userArgs[1];
                string userName = userArgs[2];
                int points = int.Parse(userArgs[3]);
                if (courses.ContainsKey(contest) && courses[contest] == password)// ако съвпадат името на курса и паролата
                {

                    if (!students.ContainsKey(userName))// ако този студент до момента не е добавен в речника със студентите
                    {
                        students[userName] = new Dictionary<string, int>();// създавам празен речник


                    }



                    if (students.ContainsKey(userName) && !students[userName].ContainsKey(contest))// ако студента вече го има, но речника за него е празен
                    {
                        students[userName][contest] = 0;// създай курс и нулеви точки
                    }
                    if (students[userName][contest] < points)// ако досегашните точки са по-малки от текущите за този курс
                    {
                        students[userName][contest] = points;// сложи по-високия резултат на студента за съответния курс
                    }

                }
                else
                {
                    continue;
                }
            }
            // за да извадя най-добрия студент ползвам OrderBy, като достъпвам вътрешния речник и взимам сумата на  елемент от поредицата (в случая това е студента с най-много точки). Той ще е първи в редицата
            string bestStudent = students.OrderByDescending(s => s.Value.Values.Sum()).First().Key;
            // най-голямата сума от точки:
            int bestResult = students.OrderByDescending(s => s.Value.Values.Sum()).First().Value.Values.Sum();


            Console.WriteLine($"Best candidate is {bestStudent} with total {bestResult} points.");
            Console.WriteLine("Ranking: ");

            foreach (var kvp in students.OrderBy(name=>name.Key))// въртя по имената на студентите и ги подреждам по азбучен ред
            {
                Console.WriteLine(kvp.Key);
                foreach (var kvpValue in kvp.Value.OrderByDescending(points=>points.Value))// въртя по точките и ги подреждам низходящо
                {
                    Console.WriteLine($"#  {kvpValue.Key} -> {kvpValue.Value}");
                }
            }

            
        }

        private static string AddNewCourse(Dictionary<string, string> courses)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                courses.Add(contest, password);
            }

            return command;
        }
    }
}