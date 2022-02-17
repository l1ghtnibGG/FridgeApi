using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using NLog;
using Repository;

namespace Fridges.Controllers
{
    [Route("api/fridge/model")]
    [ApiController]
    public class FridgeModelController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FridgeModelController(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFridgeModels()
        {
            var fridges = _repositoryManager.fridgeModel.GetAllModels(trackChanges: false);
            var fridgesDto = _mapper.Map<IEnumerable<FridgeModelDto>>(fridges);

            return Ok(fridgesDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetFridgeModel(Guid id)
        {
            var fridgeModel = _repositoryManager.fridgeModel.GetFridgeModel(id, trackChanges: false);
            if (fridgeModel == null)
            {
                _logger.LogError($"Fridge model with id: {id} does not exist");
                return NotFound();
            }
            else
            {
                var fridgeModelDto = _mapper.Map<FridgeModelDto>(fridgeModel);
                return Ok(fridgeModelDto);
            }
        }
    }
}
