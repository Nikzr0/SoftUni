using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using static ProductShop.Dtos.Export.ExportProductNamePriceDto;

namespace ProductShop
{
    public class StartUp
    {
        static IMapper mapper;
        //There is a problem with dtos in the last exercises !!
        public static void Main()
        {
            var db = new ProductShopContext();
            db.Database.EnsureCreated();

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ImportUserDto, User>();
                c.CreateMap<ImputProductDto, Product>();
                c.CreateMap<ImportCategoryDto, Category>();
                c.CreateMap<ImportCategoryProductDto, CategoryProduct>();
            });
            mapper = config.CreateMapper();

            //Console.WriteLine(ImportCategoryProducts(db, @"D:\Programming\C#\SoftUni\Code\SQL\02.EFC\09.XML\ProductShop\Datasets\categories-products.xml"));
            //Console.WriteLine(GetCategoriesByProductsCount(db));
        }
        public static string ImportUsers(ProductShopContext db, string inputXml)
        {
            using var stream = File.OpenRead(inputXml);

            var serializer = new XmlSerializer(typeof(ImportUserDto[]), new XmlRootAttribute("Users"));
            var userDtos = (ImportUserDto[])serializer.Deserialize(stream);
            var users = mapper.Map<ImportUserDto[], User[]>(userDtos);

            db.Users.AddRange(users);

            return $"Successfully imported {db.SaveChanges()}";
        }
        public static string ImportProducts(ProductShopContext db, string inputXml)
        {
            using var stream = File.OpenRead(inputXml);

            var serializer = new XmlSerializer(typeof(ImputProductDto[]), new XmlRootAttribute("Products"));
            var productDtos = (ImputProductDto[])serializer.Deserialize(stream);
            var products = mapper.Map<ImputProductDto[], Product[]>(productDtos);

            db.Products.AddRange(products);

            return $"Successfully imported {db.SaveChanges()}";
        }
        public static string ImportCategories(ProductShopContext db, string inputXml)
        {
            using var stream = File.OpenRead(inputXml);

            var serializer = new XmlSerializer(typeof(ImportCategoryDto[]), new XmlRootAttribute("Categories"));
            var categoryDtos = (ImportCategoryDto[])serializer.Deserialize(stream);
            var categories = mapper.Map<ImportCategoryDto[], Category[]>(categoryDtos);

            db.Categories.AddRange(categories);

            return $"Successfully imported {db.SaveChanges()}";
        }
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            using var stream = File.OpenRead(inputXml);

            var serializer = new XmlSerializer(typeof(ImportCategoryProductDto[]), new XmlRootAttribute("CategoryProducts"));

            var import = ((ImportCategoryProductDto[])serializer.Deserialize(stream))
                .Where(i =>
                    context.Categories.Any(x => x.Id == i.categoryId) &&
                    context.Products.Any(x => x.Id == i.productId))
                .ToArray();

            var pc = mapper.Map<ImportCategoryProductDto[], CategoryProduct[]>(import);
            context.CategoryProducts.AddRange(pc);

            return $"Successfully imported {context.SaveChanges()}";
        }
        public static string GetProductsInRange(ProductShopContext context)
        {
            var productsInRange = context.Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .OrderBy(x => x.Price)
                .Select(x => new ExportProductDto
                {
                    Name = x.Name,
                    Price = x.Price,
                    BuyerFullName = x.Buyer.FirstName + " " + x.Buyer.LastName
                })
                .Take(10).ToArray();

            var serializer = new XmlSerializer(typeof(ExportProductDto[]), new XmlRootAttribute("Products"));

            var sb = new StringBuilder();
            using (var writer = new StringWriter(sb))
            {
                serializer.Serialize(writer, productsInRange);
            }

            return sb.ToString();
        }
        public static string GetSoldProducts(ProductShopContext context)
        {
            var products = context.Users
                .Where(x => x.ProductsSold.Count > 0)
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .Select(x => new ExportUsersSoldProductsDto
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    SoldProducts = x.ProductsSold.Select(x => new ExportSoldProductsDto
                    {
                        Name = x.Name,
                        Price = (decimal)x.Price
                    }).ToArray()
                }).ToArray();

            var serializer = new XmlSerializer(typeof(ExportUsersSoldProductsDto[]), new XmlRootAttribute("User"));

            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, products);
            return sw.ToString();
        }
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(x => new ExportCategoryDto
                {
                    Name = x.Name,
                    ProductsCount = x.CategoryProducts.Count,
                    AverageProductPrice = x.CategoryProducts.Average(x => x.Product.Price),
                    TotalRevenue = x.CategoryProducts.Sum(x => x.Product.Price)
                })
                .OrderByDescending(x => x.ProductsCount)
                .ThenBy(x => x.TotalRevenue).ToArray();

            var serializer = new XmlSerializer(typeof(ExportCategoryDto[]), new XmlRootAttribute("Category"));
            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, categories);

            return sw.ToString();
        }        
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(x => x.ProductsSold.Count > 0)
                .OrderByDescending(x => x.ProductsSold.Count)
                .Select(x => new ExportUserDto
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age,
                    SoldProducts = new ExportProductCountDto
                    {
                        Count = x.ProductsSold.Count(),
                        Products = x.ProductsSold.Select(x => new ExportProductDto
                        {
                            Name = x.Name,
                            Price = x.Price
                        })
                        .OrderByDescending(x => x.Name)
                        .ToArray()
                    }
                }).Take(10).ToArray();

            var serilizer = new XmlSerializer(typeof(ExportUsersSoldProductsDto), new XmlRootAttribute("User"));
            StringWriter sw = new StringWriter();
            serilizer.Serialize(sw, users);
            return sw.ToString();
        }
    }
}