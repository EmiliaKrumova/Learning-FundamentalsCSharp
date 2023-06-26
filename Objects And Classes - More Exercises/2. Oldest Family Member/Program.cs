namespace _2._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
           Family family = new Family();// инициирам нов обект (в случая единствен от клас Семейство)
            for (int i = 0; i < numberOfPeople; i++)
            {
                string command = Console.ReadLine();
                string[] personInfo = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name , age);// иницииране на обект от класа "човек"
                family.AddMember(name, age);// използване на метода в класа семейство, за да добавя човека в семейството
               



            }

            Person oldest = family.GetOlderPerson();// променлива от тип "човек" за която използвам метода от клас "семейство" да вземе най-възрастния
            Console.WriteLine(oldest.ToString());// печатам променливата с метода ToString, който си презаписах в клас "човек"
           
        }
    }
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()// презаписан метод
        {
            return $"{Name} {Age}";
        }
    }
    public class Family
    {
       public  List<Person> family  = new List<Person>();// фийлд с хора
        



        public void AddMember (string name, int age)// метод за добавяне на хора в листа Семейство
        {
            this.family.Add(new Person(name, age));
        }
        public Person GetOlderPerson ()// метод за взимане на най-възрастния (!!!тук не трябва да се подават параметри, защото метода е вър=трешен за класа!!!)
        {
            return family.OrderByDescending(p=>p.Age).First();
        }
    }
}