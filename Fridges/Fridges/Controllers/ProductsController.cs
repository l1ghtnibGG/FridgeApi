using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;

namespace Fridges.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _repository.products.GetAllProducts(trackChanges: false);
            var productsDto = _mapper.Map<IEnumerable<ProductsDto>>(products);

            return Ok(productsDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(Guid id)
        {
            var products = _repository.products.GetProduct(id, trackChanges: false);
            if (products == null)
            {
                _logger.LogError($"Product with id: {id} does not exist");
                return NotFound();
            }
            else
            {
                var productsDto = _mapper.Map<ProductsDto>(products);
                return Ok(productsDto);
            }
        }
    }
}
