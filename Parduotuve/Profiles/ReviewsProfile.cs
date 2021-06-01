using AutoMapper;
using Parduotuve.Dtos;
using Parduotuve.Models;

namespace Parduotuve.Profiles
{
    public class ReviewsProfile : Profile
    {
        public ReviewsProfile()
        {
            CreateMap<ReviewReadDto, Review>().ReverseMap();
            CreateMap<ReviewUpdateDto, Review>().ReverseMap();
            CreateMap<ReviewCreateDto, Review>().ReverseMap();
        }
    }
}
