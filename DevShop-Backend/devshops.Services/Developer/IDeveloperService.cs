using System.Collections.Generic;
using System.Threading.Tasks;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;

namespace devshops.Services.Developer
{
    public interface IDeveloperService
    {
        Task<IEnumerable<DeveloperViewModel>>  GetAllDevelopers();
    }
}