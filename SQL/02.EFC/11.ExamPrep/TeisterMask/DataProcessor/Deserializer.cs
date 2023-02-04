namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using Data;
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
            throw new NotImplementedException();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            using var xmlReader = File.OpenRead(jsonString);
            var serializer = new XmlSerializer(typeof(ImportProjectDto[]), new XmlRootAttribute("Project"));
            var projects = (ImportProjectDto[])serializer.Deserialize(xmlReader);

            foreach (var project in projects)
            {
                if (false)
                {
                    Console.WriteLine(ErrorMessage);
                }
                context.Add(project);
                return $"Successfully imported project - {project.Name} with {project.Tasks.Count()} tasks.";
            }
            return "";
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}