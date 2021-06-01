using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Parduotuve.Data;
using Parduotuve.Dtos;
using Parduotuve.Models;
using System.Collections.Generic;
using System.Linq;

namespace Parduotuve.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IItemRepository _repository;
        private IMapper _mapper;

        public ItemsController(IItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemReadDto>> GetAllItems([FromQuery]ItemFiltersDto filters)
        {
            var items = _repository.GetAllItems(filters);

            return Ok(_mapper.Map<IEnumerable<ItemReadDto>>(items));
        }

    }
}
