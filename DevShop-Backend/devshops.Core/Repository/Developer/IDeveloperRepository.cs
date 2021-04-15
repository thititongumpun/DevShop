using System.Collections.Generic;
using System.Threading.Tasks;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;

namespace devshops.Core.Repository.Developer
{
    public interface IDeveloperRepository
    {
        Task<IEnumerable<DeveloperGroupModel>> GetAllDevelopers();
        Task<DeveloperGroupModel> GetDeveloper(int id);
        void AddDeveloper(DeveloperCreateModel developer);
        void UpdateDeveloper(DeveloperViewModel developer);
        void DeleteDeveloper(int id);
    }
}