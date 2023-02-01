using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using static ProductShop.Dtos.Export.ExportProductNamePriceDto;

namespace ProductShop.Dtos.Export
{
    [XmlType("User")]
    public class ExportUsersSoldProductsDto
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("soldProducts")]
        public ExportSoldProductsDto[] SoldProducts;
    }
}
