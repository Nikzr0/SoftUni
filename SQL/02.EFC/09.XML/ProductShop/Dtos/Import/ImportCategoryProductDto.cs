using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Dtos.Import
{
    [XmlType("CategoryProduct")]
    public class ImportCategoryProductDto
    {
        [XmlElement("CategoryId")]
        public int categoryId { get; set; }
        [XmlElement("ProductId")]
        public int productId { get; set; }
    }
}