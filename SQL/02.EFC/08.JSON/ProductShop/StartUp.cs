using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Json;
using System.Xml;
using AutoMapper;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Dtos;
using ProductShop.Models;

namespace ProductShop
{
    //There could be some problems due to the shifting between Json libraries
    public class StartUp
    {
        static IMapper mapper;
        public static void Main()
        {
            var db = new ProductShopContext();
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            //Auto mapping 
            //var config = new MapperConfiguration(c =>
            //{
            //    c.AddProfile<ProductShopProfile>();

            //});
            //mapper = config.CreateMapper();

            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<ImportUserDto, User>()
            //    .ForMember(x => x.Age, y => y.MapFrom(x => int.Parse(x.Age)));

            //});
            //var mapper = config.CreateMapper();

            //Console.WriteLine(ImportUsers(db, @"D:\Programming\C#\SoftUni\Code\SQL\02.EFC\08.JSON\ProductShop\Datasets\users.json"));
            //Console.WriteLine(ImportProducts(db, @"D:\Programming\C#\SoftUni\Code\SQL\02.EFC\08.JSON\ProductShop\Datasets\products.json"));
            //Console.WriteLine(ImportCategories(db, @"D:\Programming\C#\SoftUni\Code\SQL\02.EFC\08.JSON\ProductShop\Datasets\categories.json"));
            Console.WriteLine(ImportCategoryProducts(db, @"D:\Programming\C#\SoftUni\Code\SQL\02.EFC\08.JSON\ProductShop\Datasets\categories-products.json"));
        }
        public static string ImportUsers(ProductShopContext db, string inputJson)
        {
            var json = File.ReadAllText(inputJson);
            var users = JsonConvert.DeserializeObject<User[]>(json);

            foreach (var user in users)
            {
                db.Users.Add(user);
            }

            return $"Successfully imported {db.SaveChanges()}";
        }
        public static string ImportProducts(ProductShopContext db, string inputJson)
        {
            var jsonReader = File.ReadAllText(inputJson);
            var products = JsonConvert.DeserializeObject<Product[]>(jsonReader);

            db.Products.AddRange(products);

            return $"Successfully imported {db.SaveChanges()}";
        }
        public static string ImportCategories(ProductShopContext db, string inputJson)
        {
            var jsonReader = File.ReadAllText(inputJson);
            var categories = JsonConvert.DeserializeObject<Category[]>(jsonReader);

            foreach (var category in categories)
            {
                if (category.Name != null)
                {
                    db.Categories.Add(category);
                }
            }

            return $"Successfully imported {db.SaveChanges()}";
        }
        public static string ImportCategoryProducts(ProductShopContext db, string inputJson)
        {
            var productsAndProducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(File.ReadAllText(inputJson));

            db.CategoryProducts.AddRange(productsAndProducts);            
            return $"Successfully imported {db.SaveChanges()}";
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
            
            var json = JsonConvert.SerializeObject(filteredProducts);

            if (File.Exists("filteredProducts.json"))
            {
                File.Delete("filteredProducts.json");
            }

            File.WriteAllText("filteredProducts.json", json);

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

            var json = JsonConvert.SerializeObject(soldProducts);
            //var json = JsonConvert.Serialize(soldProducts, new JsonSerializerOptions { WriteIndented = true });

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

            var json = JsonConvert.SerializeObject(categories);
            //var json = JsonSerializer.Serialize(categories, new JsonSerializerOptions { WriteIndented = true });
            return json;
        }
        public static string GetUsersWithProducts(ProductShopContext db)
        {
            var soldProducts = db.Users
                 .Where(x => x.ProductsSold.Count > 0)
                 .OrderByDescending(x => x.ProductsSold.Count)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age,
                    ProducyInfo = x.ProductsSold
                    .Where(x => x.Name != null)
                    .Select(x => new
                    {
                        ProductName = x.Name,
                        ProductPrice = x.Price
                    })
                }).ToList();

            var json = JsonConvert.SerializeObject(soldProducts);
           // var json = JsonSerializer.Serialize(soldProducts, new JsonSerializerOptions { WriteIndented = true });
            return json;
        }
    }
}