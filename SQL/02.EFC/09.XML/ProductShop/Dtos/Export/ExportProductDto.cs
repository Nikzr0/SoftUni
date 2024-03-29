﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Dtos.Export
{
    [XmlType("Product")]
    public class ExportProductDto
    {
        [XmlElement("name")]
        public string Name;
        [XmlElement("price")]
        public decimal Price;
        [XmlElement("buyer")]
        public string BuyerFullName;
    }
}
