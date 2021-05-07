using AutoMapper;
using Parduotuve.Dtos;
using Parduotuve.Models;

namespace Parduotuve.Profiles
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            CreateMap<Item, ItemReadDto>();
            CreateMap<ItemReadDto, Item>();
        }
    }
}
