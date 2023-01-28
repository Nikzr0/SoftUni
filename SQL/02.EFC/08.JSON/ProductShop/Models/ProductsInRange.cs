using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ProductShop.Models
{
    public class PNR
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Seller { get; set; }
    }
}