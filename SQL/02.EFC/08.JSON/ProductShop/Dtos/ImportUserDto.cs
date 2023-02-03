using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace ProductShop.Dtos
{
    
    public class ImportUserDto
    {
        public string FirstName { get; set; }

        //public string LastName { get; set; }

        //public string? Age { get; set; }
    }
}