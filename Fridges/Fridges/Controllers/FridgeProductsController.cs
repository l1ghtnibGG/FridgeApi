using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;

namespace Fridges.Controllers
{
    [Route("api/fridge/products")]
    [ApiController]
    public class FridgeProductsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FridgeProductsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFridgeProducts()
        {
            var fridgeProducts = _repository.fridgeProducts.GetAllFridgeProducts(trackChanges: false);
            var fridgeProductsDto = _mapper.Map<IEnumerable<FridgeProductsDto>>(fridgeProducts);

            return Ok(fridgeProductsDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetFridgeProduct(Guid id)
        {
            var fridgeProduct = _repository.fridgeProducts.GetFridgeProduct(id, trackChanges: false);
            if (fridgeProduct == null)
            {
                _logger.LogError($"Fridge product with id: {id} does not exist");
                return NotFound();
            }
            else
            {
                var fridgeProductsDto = _mapper.Map<FridgeProductsDto>(fridgeProduct);
                return Ok(fridgeProductsDto);
            }
        }
    }
}
