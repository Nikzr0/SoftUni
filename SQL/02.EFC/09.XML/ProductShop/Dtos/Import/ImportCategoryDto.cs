using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Dtos.Import
{
    [XmlType("Category")]
    public class ImportCategoryDto
    {
        //[XmlElement("id")]
        //public int Id { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
    }
}