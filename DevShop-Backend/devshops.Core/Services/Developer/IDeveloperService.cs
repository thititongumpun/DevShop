using System.Collections.Generic;
using System.Threading.Tasks;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;

namespace devshops.Core.Developer
{
    public interface IDeveloperService
    {
        Task<IEnumerable<DeveloperGroupModel>>  GetAllDevelopers();
        Task<DeveloperGroupModel> GetDeveloper(int id);
        void AddDeveloper(DeveloperCreateModel developer);
        void UpdateDeveloper(DeveloperViewModel developer);
        void DeleteDeveloper(int id);
    }
}