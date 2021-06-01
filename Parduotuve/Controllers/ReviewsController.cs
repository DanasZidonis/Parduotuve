using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Parduotuve.Data;
using Parduotuve.Dtos;
using Parduotuve.Models;
using System.Collections.Generic;

namespace Parduotuve.Controllers
{
    [Route("api/reviews")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {

        private IReviewRepository _repository;
        private IMapper _mapper;

        [HttpPost]
        public ActionResult<ReviewReadDto> CreateReviewByItem([FromBody] ReviewCreateDto rvw)
        {

            var reviewModel = _mapper.Map<Review>(rvw);
            _repository.CreateReviewByItem(reviewModel);
            _repository.SaveChanges();

            var reviewReadDto = _mapper.Map<ReviewReadDto>(reviewModel);

            return CreatedAtRoute(nameof(GetReviewById), new { Id = reviewReadDto.Id }, reviewReadDto);
        }

        [HttpGet("{id}", Name = "GetReviewById")]
        public ActionResult<ReviewReadDto> GetReviewById(int id)
        {
            var review = _repository.GetReviewById(id);

            if (review != null)
            {
                return Ok(_mapper.Map<ReviewReadDto>(review));
            }
            return NotFound();
        }
    }
}
