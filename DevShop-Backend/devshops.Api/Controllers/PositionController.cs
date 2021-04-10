using devshops.Domain.ViewModels.Position;
using devshops.Services.Position;
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
    }
}
