using AutoMapper;
using ProductShop.Models;
using System.Xml.Serialization;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            this.CreateMap<ImportContext, User>();
        }
    }
}