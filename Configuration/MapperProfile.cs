using AutoMapper;
using CQRS_Skeleton.Domain;
using CQRS_Skeleton.Models;

namespace CQRS_Skeleton.Configuration
{
    public class MapperProfile: Profile
    {
        public MapperProfile() 
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
