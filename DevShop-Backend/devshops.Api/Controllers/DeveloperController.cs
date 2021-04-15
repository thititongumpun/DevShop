using System.Threading.Tasks;
using devshops.Core.Developer;
using devshops.Domain.Developer.ViewModels;
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
        public DeveloperController(IDeveloperService developerService, ILogger<DeveloperController> logger)
        {
            _developerService = developerService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<DeveloperGroupModel>> GetAllDevelopers()
        {
            var developers = await _developerService.GetAllDevelopers();
            _logger.LogInformation("Geting all developers ...");
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperGroupModel>> GetDeveloper(int id)
        {
            var developer = await _developerService.GetDeveloper(id);
            _logger.LogInformation($"Geting developer {id}...");
            return Ok(developer);
        }

        [HttpPost]
        public IActionResult AddDeveloper([FromBody] DeveloperCreateModel developer)
        {
            _developerService.AddDeveloper(developer);
            _logger.LogInformation("Insert developer");
            return Ok(developer);
        }

        [HttpPut]
        public IActionResult UpdateDeveloper([FromBody] DeveloperViewModel developer)
        {
            _developerService.UpdateDeveloper(developer);
            _logger.LogInformation("Update developer");
            return Ok(developer);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDeveloper(int id)
        {
            _developerService.DeleteDeveloper(id);
            _logger.LogInformation($"Delete developer {id}");
            return NoContent();
        }
    }
}