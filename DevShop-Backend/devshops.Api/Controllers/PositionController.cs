using devshops.Core.Position;
using devshops.Domain.ViewModels.Position;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devshops.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        protected readonly IPositionService _positionService;
        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet]
        public async Task<ActionResult<PositionViewModel>> GetAllPositions()
        {
            var position = await _positionService.GetAllPositions();
            return Ok(position);
        }

        [HttpPost]
        public IActionResult AddPosition([FromBody] PositionCreateModel position)
        {
            _positionService.AddPosition(position);
            return Ok(position);
        }

        [HttpPut]
        public IActionResult UpdatePosition([FromBody] PositionViewModel position)
        {
            _positionService.UpdatePosition(position);
            return Ok(position);
        }

        [HttpDelete]
        public IActionResult DeletePosition(int id)
        {
            _positionService.DeletePosition(id);
            return NoContent();
        }
    }
}
