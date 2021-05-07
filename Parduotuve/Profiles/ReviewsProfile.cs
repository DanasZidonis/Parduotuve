using AutoMapper;
using Parduotuve.Dtos;
using Parduotuve.Models;

namespace Parduotuve.Profiles
{
    public class ReviewsProfile : Profile
    {
        public ReviewsProfile()
        {
            CreateMap<Review, ReviewReadDto>();
            CreateMap<ReviewReadDto, Review>();
        }
    }
}
