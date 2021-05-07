using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Parduotuve.Data;
using Parduotuve.Dtos;
using System.Collections.Generic;

namespace Parduotuve.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IShopRepo _repository;
        private IMapper _mapper;

        public ItemsController(IShopRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemReadDto>> GetAllItems()
        {
            var items = _repository.GetAllItems();

            return Ok(_mapper.Map<IEnumerable<ItemReadDto>>(items));
        }

        [HttpGet("ByBest")]
        public ActionResult<IEnumerable<ItemReadDto>> GetItemsByBestReviews()
        {
            var items = _repository.GetItemsByBestReviews();

            return Ok(_mapper.Map<IEnumerable<ItemReadDto>>(items));
        }
    }
}
