using ProductShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.Dtos
{
    public class ImportProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}