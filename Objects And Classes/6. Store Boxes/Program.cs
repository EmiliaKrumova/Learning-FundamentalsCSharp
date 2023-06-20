using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            List<Box> boxes = new List<Box>();
            while((data = Console.ReadLine()) != "end")
            {
                string[] dataArgs = data.Split();
                string serialNum = dataArgs[0];
                string itemName = dataArgs[1];
                int quantity = int.Parse(dataArgs[2]);
                decimal itemPrice = decimal.Parse(dataArgs[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNum, item, quantity);
                boxes.Add(box);


            }
            foreach(Box box in boxes.OrderByDescending(x=>x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                //{ boxSerialNumber}
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQty}");
                //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
                Console.WriteLine($"-- ${box.PriceForBox:f2}");

            }
        }
    }
    public class Item
    {
        public Item(string itemName, decimal itemPrice) 
        {
            Name = itemName;
            Price = itemPrice;

        }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box (string serialNumber, Item item, int itemQty)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQty = itemQty;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQty { get; set; }
        public decimal PriceForBox {
            get
            {
                return ItemQty * Item.Price;
            }
                  }
    }
}
