namespace _3._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product;
            Dictionary<string, List<decimal>> products = new Dictionary<string, List<decimal>>();// създавам празен речник с ключ име на продукт и стойност (лист, който ще съдържа цена и количество)
            while ((product = Console.ReadLine()) != "buy")// ако командата е различна от "buy" 
            {
                string[] productArgs = product.Split(); //сплитвам я по спейс
                string prodName = productArgs[0];// име на продукта - ключ
                decimal price = decimal.Parse(productArgs[1]);// цена
                decimal quantity = decimal.Parse(productArgs[2]);// количество
                if (!products.ContainsKey(prodName))// ако в речника няма такъв ключ
                {
                    products[prodName] = new List<decimal>() { price, quantity };// създавам ключ с това има и му слагам нов лист, където сетвам първоначалната цена и количество
                }
                else// ако вече е създаден такъв продукт
                {
                    products[prodName][0] = price;// променям цената (достъпвам я като индексирам 1 речника, после листа 
                    products[prodName][1] += quantity;// добавям ново количество от същия продукт
                }


            }
            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:f2}");
                // принтирам за всеки ключ - > умножавам стойността ( в случая цената) на индекс 0 по количеството на индекс 1 в листа, който е вложен в речника и закръглям до 2-ри знак след запетаята.
            }
        }
    }
}