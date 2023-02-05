namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    using System.Data.SqlTypes;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.Data.Models;
    using TeisterMask.DataProcessor.ImportDto;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";

        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {
            using var xmlReader = File.OpenRead(xmlString);
            var serializer = new XmlSerializer(typeof(ImportProjectDto[]), new XmlRootAttribute("Project"));
            var projects = (ImportProjectDto[])serializer.Deserialize(xmlReader);

            foreach (var project in projects)
            {
                if (project.Name.Length < 2 || project.Name.Length > 40 || project.Name == null)
                {
                    Console.WriteLine(ErrorMessage);
                }
                else if (project.OpenDate == null)
                {
                    Console.WriteLine(ErrorMessage);
                }
                context.Add(project);
                // Return could be automated
                return $"Successfully imported project - {project.Name} with {project.Tasks.Count()} tasks.";
            }
            return $"{context.SaveChanges()}";

        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var json = File.ReadAllText(jsonString);
            var users = JsonConvert.DeserializeObject<Employee[]>(json);

            foreach (var user in users)
            {
                if (user.Username.Length > 40 || user.Username.Length < 4 || user.Username == null)
                {
                    Console.WriteLine(ErrorMessage);
                }
                else if (!Regex.IsMatch(user.Username, "^[a-zA-Z0-9]+$"))
                {
                    Console.WriteLine(ErrorMessage);
                }
                else if (string.IsNullOrEmpty(user.Email))
                {
                    Console.WriteLine(ErrorMessage);
                }
                else if (!new EmailAddressAttribute().IsValid(user.Email))
                {
                    Console.WriteLine(ErrorMessage);
                }
                else if (!Regex.IsMatch(user.Phone, @"^\d{3}-\d{3}-\d{4}$"))
                {
                    Console.WriteLine(ErrorMessage);
                }
                context.Add(user);
                // Return could be automated
                return $"Successfully imported employee - {user.Username} with {user.EmployeesTasks.Count()} tasks.";
            }
            return $"{context.SaveChanges()}";
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}