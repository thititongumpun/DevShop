using System.Collections.Generic;
using System.Threading.Tasks;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;

namespace devshops.Core.Repository.Developer
{
    public interface IDeveloperRepository
    {
        Task<IEnumerable<DeveloperViewModel>> GetAllDevelopers();
    }
}