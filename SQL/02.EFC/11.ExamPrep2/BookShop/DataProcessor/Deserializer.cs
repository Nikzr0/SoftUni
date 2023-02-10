namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using AutoMapper;
    using BookShop.Data.Models.Enums;
    using BookShop.Data.Models;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;
    using System.Xml;
    using static System.Reflection.Metadata.BlobBuilder;
    using System.Diagnostics;
    using System.Security.Cryptography;
    using System.Xml.Linq;


    public class Deserializer
    {
        private static IMapper mapper;

        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";
        /*
         Impor method is not working 
         There is a problem in DateTime validation 
         */
        public static string ImportBooks(BookShopContext context, string xmlString)
        {

            // Mapping
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ImportBooksDto, Book>()
                .ForMember(x => x.Genre, option => option.MapFrom(source => source.Genre));
                // It specify a custom mapping for the Genre property

            });
            mapper = config.CreateMapper();

            using (StringReader reader = new StringReader(xmlString))
            {
                var serializer = new XmlSerializer(typeof(ImportBooksDto[]), new XmlRootAttribute("Books"));
                var booksDtos = (ImportBooksDto[])serializer.Deserialize(reader);

                //var books = mapper.Map<ImportBooksDto[], Book[]>(booksDtos);
                //context.Books.AddRange(books);

                foreach (var bookDto in booksDtos)
                {
                    if (bookDto.Genre > 3 || bookDto.Genre <= 0)
                    {
                        Console.WriteLine(ErrorMessage);
                    }

                    //DateTime parsedDate;
                    //if (DateTime.TryParse(bookDto.PublishedOn,out parsedDate))
                    //{
                    //    Console.WriteLine(ErrorMessage);
                    //}
                    if (bookDto.Price < 0 || bookDto.Price > decimal.MaxValue)
                    {
                        Console.WriteLine(ErrorMessage);
                    }

                    if (bookDto.Pages > int.MaxValue || bookDto.Pages < 0)
                    {
                        Console.WriteLine(ErrorMessage);
                    }

                    var book = new Book
                    {
                        Name = bookDto.Name,
                        Genre = (Genre)bookDto.Genre,
                        Pages = bookDto.Pages,
                        Price = bookDto.Price,
                        PublishedOn = bookDto.PublishedOn,
                    };

                    context.Books.Add(book);
                }
            }

            return $"Number of inserts {context.SaveChanges()}";
        }
        public static string ImportAuthors(BookShopContext context, string jsonString)
        {
            var authors = JsonConvert.DeserializeObject<Author[]>(jsonString);
                      
            //var authors = JsonConvert.DeserializeObject<ImportAuthorDto[]>(json);

            foreach (var author in authors)
            {
                context.Authors.Add(author);
            }

            return $"Successfully imported {context.SaveChanges()}";
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}