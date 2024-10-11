using System;
using System.Collections.Generic;

namespace Inventory
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, object>> inventory = new Dictionary<string, Dictionary<string, object>>();

        static void AddProduct()
        {
            Console.Write("Enter Product ID: ");
            string productId = Console.ReadLine();

            if (inventory.ContainsKey(productId))
            {
               Console.WriteLine("Product ID already exists.");
            }
            
            else
            {
                var productDetails = new Dictionary<string, object>(); 

                Console.Write("Enter Product Name : ");
                productDetails.Add("Name", Console.ReadLine());

                Console.Write("Enter Product Price : ");
                productDetails.Add("Price", decimal.Parse(Console.ReadLine()));

                Console.Write("Enter Product Stock : ");
                productDetails.Add("Stock", int.Parse(Console.ReadLine())); 

                inventory[productId] = productDetails; 
                Console.WriteLine("Product added successfully.");
            }
                
        }

        static void UpdateStock()
        {
            Console.Write("Enter Product ID : ");
            string updateStock = Console.ReadLine(); 

            if(inventory.ContainsKey(updateStock))
            {
                Console.Write("Enter New Stock Quantity : ");
                int newStock = int.Parse(Console.ReadLine());

                inventory[updateStock]["Stock"] = newStock; 
                Console.WriteLine("Stock updated successfully");
            }
            else
            {
                System.Console.WriteLine("Product does not exist.");
            }
           
        }

        static void GetProductDetails()
        {
            Console.Write("Enter Product ID: ");
            string prod = Console.ReadLine();

            if(inventory.ContainsKey(prod))
            {
                var product = inventory[prod]; 
                Console.WriteLine($"Product ID: {prod}");
                Console.WriteLine($"Name: {product["Name"]}");
                Console.WriteLine($"Price: {product["Price"]}");
                Console.WriteLine($"Stock: {product["Stock"]}");
             }

             else 
             {
                System.Console.WriteLine("Product does not exist.");
             }
        }
            

        static List<string> GetLowStockProducts()
        {
            List<string> lowStock = new List<string>(); 

            Console.Write("Enter Stock Threshold : ");
            int threshold = int.Parse(Console.ReadLine()); 

            foreach (var product in inventory) 
            {
                if ((int)product.Value["Stock"] < threshold) 
                {
                    lowStock.Add(product.Key); 
                }
            }

            if (lowStock.Count > 0) 
            {
                Console.WriteLine("Low Stock Products : ");
                foreach (var id in lowStock)
                {
                    Console.WriteLine(id);
                }
            }
            else
            {
                Console.WriteLine("No low stock products found.");
            }
            return lowStock; 
        }

        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductDetails();
                        break;
                    case "4":
                        GetLowStockProducts();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
            }
        }
    }
}
