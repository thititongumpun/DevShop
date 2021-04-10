using System.Threading.Tasks;
using devshops.Domain.Developer.ViewModels;
using devshops.Services.Developer;
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
    }
}