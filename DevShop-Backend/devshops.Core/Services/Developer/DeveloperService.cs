using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using devshops.Core.Repository;
using devshops.Core.Repository.Developer;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace devshops.Core.Developer
{
    public class DeveloperService : IDeveloperService
    {
        protected readonly IDeveloperRepository _developerRepository;

        public DeveloperService(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }

        public async Task<IEnumerable<DeveloperGroupModel>> GetAllDevelopers()
        {
            return await _developerRepository.GetAllDevelopers();
        }

        public async Task<DeveloperGroupModel> GetDeveloper(int id)
        {
            return await _developerRepository.GetDeveloper(id);
        }
    }
}
