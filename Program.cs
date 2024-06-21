using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class InventoryItem
    {
        // Properties
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        // Constructor to initialize the inventory items
        public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
        {
            ItemName = itemName;
            ItemId = itemId;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        // helper  methods to manage the inventory

        // Update the price of the item
        public void UpdatePrice(double updatedPrice)
        {
            Price = updatedPrice;
        }

        // Restock the item for taking additional quantity  as a paramter
        public void RestockItem(int extraQuantity)
        {
            QuantityInStock += extraQuantity;
        }

        // method to sell the items
        public void SellItem(int quantitySold)
        {
            if (QuantityInStock >= quantitySold)
            {
                QuantityInStock -= quantitySold;
            }
            else
            {
                Console.WriteLine("There is no stock to complete the purchase");
            }
        }

        // Check if an item is in stock available for sale
        public bool IsInStock()
        {
            //return true if quantity is  greater than zero
            return QuantityInStock > 0;
        }

        // Print  details of items in the inventory management
        public void PrintDetails()
        {
            Console.WriteLine($"Item Name: {ItemName}");
            Console.WriteLine($"Item ID: {ItemId}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of InventoryItem
            InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
            InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

            // 1 . Print details of all items
            Console.WriteLine("Starting  Inventory of all  the Itemms");
            item1.PrintDetails();
            item2.PrintDetails();

            // 2 . Sell some items
            item1.SellItem(2); // Selling 2 Laptops
            item2.SellItem(5); // Selling 5 Smartphones

            // 3 . Print updated details after selling laptop and smartphone
            Console.WriteLine("Inventory after selling  2 laptop and  5 smartpohone:");
            item1.PrintDetails();
            item2.PrintDetails();

            // 4 . Restock an item
            item1.RestockItem(5); // adding 5 Laptops
            item2.RestockItem(3); // adding 3 Smartphones

            //5 .  Print updated details after restocking laptop and smart phone
            Console.WriteLine("Inventory after restocking  laptop and smart phone:");
            item1.PrintDetails();
            item2.PrintDetails();

            // 6 . Check if items are in stock and print a message related to stock using ternary operator
            Console.WriteLine("Stock status of inventory management:");
            Console.WriteLine($"{item1.ItemName} is {(item1.IsInStock() ? "in stock" : "out of stock")}");
            Console.WriteLine($"{item2.ItemName} is {(item2.IsInStock() ? "in stock" : "out of stock")}");
        }
    }
}