using System.Xml.Linq;

namespace _5._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string people = Console.ReadLine();
            string[] users = people.Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();
            for (int i = 0; i < users.Length; i++)
            {
                string[] currUser = users[i].Split("=");
                string userName = currUser[0];
                decimal money = decimal.Parse(currUser[1]);
                Person person = new Person(userName,money);
                persons.Add(person);
            }
            string products = Console.ReadLine();
            string[] productsInfo = products.Split(";", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0;i < productsInfo.Length; i++)
            {
                string[] currProduct = productsInfo[i].Split("=");
                string productName = currProduct[0];
                decimal price = decimal.Parse(currProduct[1]);
                Product product = new Product (productName, price);
            }
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string userName = commandArgs[0];
                string product = commandArgs[1];
                //if (!persons.Any(d => d.Name == userName))
                //{
                //    persons.Add(new Person(person));
                //}

                //departments.AddNewEmployee(name, salary);
                //persons.Find(d => d.Name == userName).AddNewProduct( );

            }
           

        }
    }
    public class Person
    {
        public Person (string userName, decimal money)
        {
            Name = userName;
            Money = money;
        }
        List<Product> products = new List<Product>();
        public string Name { get; set; }
        public decimal Money { get; set; }
        public void AddNewProduct(string product, decimal price)// add new employee with it`s salary to the Department
        {
            if (Money >= price)
            {
                this.Money -= price;
                this.products.Add(new Product(product, price));

            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product}");
            }
            
        }
    }
    public class Product
    {
        public Product(string productName, decimal price) 
        {
            Name = productName;
            Price = price;
            
        }
        public string Name { get; set; }    
        public decimal Price { get; set; }
    }
    
}