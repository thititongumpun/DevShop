using devshops.Core.Repository.DeveloperPosition;
using devshops.Core.Services.DeveloperPosition;
using devshops.Domain.ViewModels.DeveloperPositionViewModel;
using devshops.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devshops.Api.Controllers
{
    [Authorize(Roles = Roles.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperPositionController : ControllerBase
    {
        private readonly IDeveloperPositionService _dpService;
        public DeveloperPositionController(IDeveloperPositionService dpService)
        {
            _dpService = dpService;
        }

        [HttpGet]
        public async Task<ActionResult<DeveloperPositionViewModel>> GetAll()
        {
            var result = await _dpService.GetDeveloperPosition();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddDeveloperPosition([FromBody] DeveloperPositionCreateModel createModel)
        {
            _dpService.AddDeveloperPosition(createModel);
            return Ok(createModel);
        }
    }
}
