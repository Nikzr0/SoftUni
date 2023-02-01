using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Serialization;
using static ProductShop.Dtos.Export.ExportProductNamePriceDto;

namespace ProductShop.Dtos.Export
{
    [XmlType("Product")]
    public class ExportProductCountDto
    {
        [XmlElement("count")]
        public int Count { get; set; }

        
        [XmlArray("products")]
        public ExportProductNamePriceDto Products { get; set; }
    }
}
