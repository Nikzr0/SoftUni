using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            var db = new ProductShopContext();
            db.Database.EnsureCreated();
            Console.WriteLine(GetProductsInRange(db));
        }

        public static string ImportUsers(ProductShopContext db, string inputJson)
        {
            var jsonReader = File.ReadAllText(inputJson);
            var users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(jsonReader));

            db.Users.AddRange(users);
            db.SaveChanges();
            return $"Successfully imported {users.Count}";
        }
        public static string ImportProducts(ProductShopContext db, string inputJson)
        {
            var jsonReader = File.ReadAllText(inputJson);
            var products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(jsonReader));

            db.Products.AddRange(products);
            db.SaveChanges();
            return $"Successfully imported {products.Count}";
        }
        public static string ImportCategories(ProductShopContext db, string inputJson)
        {
            var jsonReader = File.ReadAllText(inputJson);
            var categories = JsonSerializer.Deserialize<List<Category>>(jsonReader);

            foreach (var category in categories)
            {
                if (category.Name != null)
                {
                    db.Categories.Add(category);
                }
            }
            db.SaveChanges();

            return $"Successfully imported {categories.Count}";
        }
        public static string ImportCategoryProducts(ProductShopContext db, string inputJson)
        {
            var jsonReader = File.ReadAllText(inputJson);
            var productsAndProducts = JsonSerializer
                .Deserialize<List<CategoryProduct>>(File.ReadAllText(jsonReader));

            db.CategoryProducts.AddRange(productsAndProducts);
            db.SaveChanges();
            return $"Successfully imported {productsAndProducts.Count}";
        }
        public static string GetProductsInRange(ProductShopContext db)
        {
            var filteredProducts = db.Products
             .Select(x => new
             {
                 x.Name,
                 x.Price,
                 x.Seller
             })
             .Where(p => p.Price >= 10 && p.Price <= 1000)
             .OrderBy(p => p.Price)
             .ToList();


            var json = JsonSerializer.Serialize(filteredProducts, new JsonSerializerOptions { WriteIndented = true });

            if (File.Exists("filteredProducts.json"))
            {
                File.Delete("filteredProducts.json");
            }

            File.WriteAllText("filteredProducts.json", json);

            //return json; {It works the same way as without creating a json file}
            return File.ReadAllText("filteredProducts.json");
        }
        public static string GetSoldProducts(ProductShopContext db)
        {
            var soldProducts = db.Users
                 .Where(x => x.ProductsSold.Count > 0)
                 .OrderBy(x => x.LastName)
                 .ThenBy(x => x.FirstName)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    ProductsSold = x.ProductsSold.Select(x => new
                    {
                        PName = x.Name,
                        PPrice = x.Price,
                        BuyerFirstName = x.Buyer.FirstName,
                        BuyerLastName = x.Buyer.LastName
                    }).ToList(),
                }).ToList();

            var json = JsonSerializer.Serialize(soldProducts, new JsonSerializerOptions { WriteIndented = true });

            return json;
        }
        public static string GetCategoriesByProductsCount(ProductShopContext db)
        {
            var categories = db.Categories
                .OrderByDescending(x => x.CategoryProducts.Count)
                .Select(x => new
                {
                    Name = x.Name,
                    ProductCount = x.CategoryProducts.Count,
                    AveragePrice = $"{x.CategoryProducts.Select(p => p.Product.Price).Average(x => x):f2}",
                    TotalRevanue = $"{x.CategoryProducts.Select(p => p.Product.Price).Sum(x => x):f2}"
                }).ToList();

            var json = JsonSerializer.Serialize(categories, new JsonSerializerOptions { WriteIndented = true });
            return json;
        }
        public static string GetUsersWithProducts(ProductShopContext db)
        {
            var soldProducts = db.Users
                 .Where(x => x.ProductsSold.Count > 0)
                 .OrderByDescending(x=>x.ProductsSold.Count)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age,
                    ProducyInfo = x.ProductsSold
                    .Where(x=>x.Name != null)
                    .Select(x=> new { 
                     ProductName = x.Name,
                     ProductPrice = x.Price
                    })
                }).ToList();

            var json = JsonSerializer.Serialize(soldProducts, new JsonSerializerOptions { WriteIndented = true });
            return json;
        }
    }
}