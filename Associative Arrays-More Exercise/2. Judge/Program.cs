using System.Collections.Specialized;

namespace _2._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Речник <курс, речник<студент,точки>>
            Dictionary<string, Dictionary<string, int>> courses = new Dictionary<string, Dictionary<string, int>>();

            // речник <студент,речник<курс, точки>>
            Dictionary<string, Dictionary<string, int>> studentsStats = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] studentArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentArgs[0];
                string course = studentArgs[1];
                int points = int.Parse(studentArgs[2]);


                if (!courses.ContainsKey(course))// ако речника с курсове НЕ СЪДЪРЖА сегашния курс
                {
                    courses[course] = new Dictionary<string, int>();// инициализирай вложения речник
                }
                if (courses.ContainsKey(course) && !courses[course].ContainsKey(studentName))// ако съдържа курса, но НЕ СЪДЪРЖА студента
                {
                    courses[course][studentName] = 0;// инициализирай студента с 0 точки
                }
                if (points > courses[course][studentName])// ако точките от конзолата за този курс на този студент са повече от записаните - презапиши точките
                {
                    courses[course][studentName] = points;
                }


                if (!studentsStats.ContainsKey(studentName))// ако речника за студентите не съдържа сегашния студент
                {
                    studentsStats[studentName] = new Dictionary<string, int>();// инициализирай вложен речник за този студент
                }
                if (studentsStats.ContainsKey(studentName) && !studentsStats[studentName].ContainsKey(course))// ако не съдържа този курс
                {
                    studentsStats[studentName][course] = 0;// инициализирай курса с 0 точки
                }
                if (points> studentsStats[studentName][course])// ако точките от конзолата са повече от досега записаните
                {
                    studentsStats[studentName][course] = points;// презапиши точките с по-високия резултат
                }


            }
            foreach (var kvp in courses)// за всяка двойка в речника курсове
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");// изпиши името на курса и колко хора са участвали в него
                //"{position}. {username} <::> {points}"
                int position = 1;
                foreach (var kvp2 in kvp.Value.OrderByDescending(points => points.Value).ThenBy(s=>s.Key))// за всяка двойка във вложения речник(студент и точки)
                    // сортирай низходящо по точките, а после по азбучен ред по име на студента
                {

                    Console.WriteLine($"{position}. {kvp2.Key} <::> {kvp2.Value}");// изпиши позиция, студент, точки
                    position++;
                }

            }

            var finalRanking = new Dictionary<string, double>();// нов речник (студент, сумирани точки)

            foreach (var participant in studentsStats)// за всички студенти в речника със студентите
            {
                if (!finalRanking.ContainsKey(participant.Key))// ако новия речник не съдържа името на студента
                {
                    finalRanking[participant.Key] = 0;// инициализирай нулеви точки на това име в новия речник
                }
                // с това се пълни третия речник с имената на студентите и нулеви точки
                                   
                // 
                foreach (var kvp in participant.Value)// тук взимам двойка (курс - точки)
                {
                    finalRanking[participant.Key] += kvp.Value;// за всеки студент - сумирам точките, минавайки през всеки курс
                }
            }
            Console.WriteLine("Individual standings:");
            int position1 = 1;
            foreach (var kvp in finalRanking.OrderByDescending(x => x.Value).ThenBy(x => x.Key))// сортиране на последния речник 1-во по точки, а после по азбучен ред на имената на студентите
            {
                Console.WriteLine($"{position1}. {kvp.Key} -> {kvp.Value}");
                position1++;
            }
                
 
          
        }
    }
}