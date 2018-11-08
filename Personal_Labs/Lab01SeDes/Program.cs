using System;
using Newtonsoft.Json;

namespace Lab01SeDes
{
    class Program
    {
        public static string DoSerialization()
        {
            Product[] products = {
        new Product{ ID = 101, Name = "Product-101", Price=43.2},
        new Product{ ID = 102, Name = "Product-102", Price=56.9},
        new Product{ ID = 103, Name = "Product-103", Price=12.3},
        new Product{ ID = 104, Name = "Product-104", Price=93.7}
    };
            var json = JsonConvert.SerializeObject(products);
            return json;
        }

        // Deserialize a JSON string back to a Rocket array
        public static void DoDeserialization(string json)
        {
            var products = JsonConvert.DeserializeObject<Product[]>(json);
            foreach (var product in products)
            {
                System.Console.WriteLine($"ID:{product.ID} Name:{product.Name} Price:{product.Price}");
            }
        }
        static void Main(string[] args)
        {
            var json = DoSerialization();
            System.Console.WriteLine(json);
            System.Console.WriteLine("================");
            DoDeserialization(json);
        }
    }
}
