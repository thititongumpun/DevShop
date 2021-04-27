using System.Threading.Tasks;
using devshops.Api.Filter;
using devshops.Core.Developer;
using devshops.Domain.Developer.ViewModels;
using devshops.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace devshops.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        protected readonly IDeveloperService _developerService;
        protected readonly ILogger<DeveloperController> _logger;
        protected readonly ICurrentUserService _currentUserService;
        public DeveloperController(
            IDeveloperService developerService, 
            ILogger<DeveloperController> logger, 
            ICurrentUserService currentUserService
            )
        {
            _developerService = developerService;
            _logger = logger;
            _currentUserService = currentUserService;
        }

        [HttpGet]
        [Cached(600)]
        public async Task<ActionResult<DeveloperGroupModel>> GetAllDevelopers()
        {
            var developers = await _developerService.GetAllDevelopers();
            _logger.LogInformation($"Geting all {developers} by {_currentUserService.Username}");
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperGroupModel>> GetDeveloper(int id)
        {
            var developer = await _developerService.GetDeveloper(id);


            if (developer == null)
            {
                return NotFound();
            }
            _logger.LogInformation($"Getting developer {id} by {_currentUserService.Username}");

            return Ok(developer);
        }

        [HttpPost]
        public IActionResult AddDeveloper([FromBody] DeveloperCreateModel developer)
        {
            _developerService.AddDeveloper(developer);
            _logger.LogInformation($"Insert developer by {_currentUserService.Username}");
            return Ok(developer);
        }

        [HttpPut]
        public IActionResult UpdateDeveloper([FromBody] DeveloperViewModel developer)
        {
            _developerService.UpdateDeveloper(developer);
            _logger.LogInformation($"Update developer by {_currentUserService.Username}");
            return Ok(developer);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDeveloper(int id)
        {
            _developerService.DeleteDeveloper(id);
            _logger.LogInformation($"Delete developer {id} by {_currentUserService.Username}");
            return NoContent();
        }
    }
}