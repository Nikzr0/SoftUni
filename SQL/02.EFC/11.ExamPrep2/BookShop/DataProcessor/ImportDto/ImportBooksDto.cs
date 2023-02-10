using BookShop.Data.Models.Enums;
using BookShop.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace BookShop.DataProcessor.ImportDto
{
    [XmlType("Book")]
    public class ImportBooksDto
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Genre")]
        public int Genre { get; set; }
        [XmlElement("Price")]
        public decimal Price { get; set; }
        [XmlElement("Pages")]
        public int Pages { get; set; }

        [XmlElement("PublishedOn")]
        public DateTime PublishedOn { get; set; }
    }
}