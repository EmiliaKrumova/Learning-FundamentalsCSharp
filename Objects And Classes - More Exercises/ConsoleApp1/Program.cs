namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family(); // Create a Family object

            for (int i = 0; i < numberOfPeople; i++)
            {
                string command = Console.ReadLine();
                string[] personInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);

                family.AddMember(name, age); // Call AddMember method on the Family object
            }

            // Now you can perform other operations on the family object
            // For example, you can access the People list or call other methods

            Console.WriteLine(String.Join("", family.People));
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

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }

    public class Family
    {
        public List<Person> People = new List<Person>();

        public void AddMember(string name, int age)
        {
            this.People.Add(new Person(name, age));
        }

        public int GetOlderPerson(List<Person> People, int age)
        {
            return People.OrderByDescending(p => p.Age).First().Age;
        }
    }
    }
