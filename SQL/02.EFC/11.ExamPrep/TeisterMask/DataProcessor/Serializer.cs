
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Xml.Serialization;

using AutoMapper;

using Newtonsoft.Json;
using TeisterMask.Data;
using TeisterMask.DataProcessor.ExportDto;
using TeisterMask.Data.Models;
using TeisterMask.DataProcessor.ImportDto;

namespace TeisterMask.DataProcessor
{
    public class Serializer
    {
        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportProjectDto[]), new XmlRootAttribute("Projects"));

            // not sure what this is for
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using StringWriter sw = new StringWriter(sb);

            Project[] projects = context
                .Projects
                .Where(p => p.Tasks.Any())
                .ToArray();

            ExportProjectDto[] projectDtos = Mapper.Map<ExportProjectDto[]>(projects)
                .OrderByDescending(p => p.TasksCount)
                .ThenBy(p => p.Name)
                .ToArray();

            xmlSerializer.Serialize(sw, projectDtos, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {
            // Lable propblem!!
            // ExecutionType propblem!!
            var employees = context.Employees
                .Where(e => e.EmployeesTasks.Any(x => x.Task.OpenDate >= date))
                .ToArray()
                .Select(x => new ExportEmployeeDto
                {
                    Username = x.Username,
                    Tasks = x.EmployeesTasks
                        .Where(et => et.Task.OpenDate >= date)
                        .ToArray()
                        .OrderByDescending(et => et.Task.DueDate)
                        .ThenBy(et => et.Task.Name)
                        .Select(x
                        => new 
                        {
                            TaskName = x.Task.Name,
                            OpenDate = x.Task.OpenDate.ToString("d", CultureInfo.InvariantCulture),
                            DueDate = x.Task.DueDate.ToString("d", CultureInfo.InvariantCulture),
                            LabelType = x.Task.LabelType.ToString(),
                            ExecutionType = x.Task.ExecutionType.ToString()
                        })
                        .ToArray()
                })
                .OrderByDescending(e => e.Tasks.Length)
                .ThenBy(e => e.Username)
                .Take(10)
                .ToArray();

            return JsonConvert.SerializeObject(employees, Formatting.Indented);
        }
    }
}