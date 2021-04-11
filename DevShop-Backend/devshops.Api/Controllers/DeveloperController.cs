using System.Threading.Tasks;
using devshops.Core.Developer;
using devshops.Domain.Developer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace devshops.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        protected readonly IDeveloperService _developerService;
        public DeveloperController(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        [HttpGet]
        public async Task<ActionResult<DeveloperViewModel>> GetAllDevelopers()
        {
            var developers = await _developerService.GetAllDevelopers();
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperViewModel>> GetDeveloper(int id)
        {
            var developer = await _developerService.GetDeveloper(id);
            return Ok(developer);
        }
    }
}