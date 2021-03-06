using devshops.Api.Filter;
using devshops.Core.Position;
using devshops.Domain.ViewModels.Position;
using devshops.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace devshops.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        protected readonly IPositionService _positionService;
        protected readonly ILogger<PositionController> _logger;
        public PositionController(IPositionService positionService, ILogger<PositionController> logger)
        {
            _positionService = positionService;
            _logger = logger;
        }

        [HttpGet]
        [Cached(600)]
        public async Task<ActionResult<PositionGroupModel>> GetAllPositions()
        {
            var positions = await _positionService.GetAllPositions();
            _logger.LogInformation("Getting all Positions");
            return Ok(positions);
        }

        [HttpGet("{id}")]
        [Cached(600)]
        public async Task<ActionResult<PositionGroupModel>> GetAllPositions(int id)
        {
            var position = await _positionService.GetPositionById(id);

            if (position == null)
            {
                return NotFound();
            }

            _logger.LogInformation($"Getting position {id}");
            return Ok(position);
        }

        [HttpPost]
        public IActionResult AddPosition([FromBody] PositionCreateModel position)
        {
            _positionService.AddPosition(position);
            _logger.LogInformation("Insert Position");
            return Ok(position);
        }

        [HttpPut]
        public IActionResult UpdatePosition([FromBody] PositionViewModel position)
        {
            _positionService.UpdatePosition(position);
            _logger.LogInformation("Update Position");
            return Ok(position);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePosition(int id)
        {
            _positionService.DeletePosition(id);
            _logger.LogInformation($"Delete Position {id}");
            return NoContent();
        }
    }
}
