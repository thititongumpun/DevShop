using devshops.Core.Repository.DeveloperPosition;
using devshops.Domain.ViewModels.DeveloperPositionViewModel;
using devshops.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Services.DeveloperPosition
{
    public class DeveloperPositionService : IDeveloperPositionService
    {
        protected readonly IDeveloperPositionRepository _developerPositionRepository;
        protected readonly IDateTime _dateTime;
        protected readonly ICurrentUserService _currentUserService;
        public DeveloperPositionService(
            IDeveloperPositionRepository developerPositionRepository,
            IDateTime dateTime,
            ICurrentUserService currentUserService
            )
        {
            _developerPositionRepository = developerPositionRepository;
            _dateTime = dateTime;
            _currentUserService = currentUserService;
        }

        public async Task<IEnumerable<DeveloperPositionViewModel>> GetDeveloperPosition()
        {
            var developerPosition = await _developerPositionRepository.GetDeveloperPosition();
            return developerPosition;
        }

        public void AddDeveloperPosition(DeveloperPositionCreateModel createModel)
        {
            createModel.Created = _dateTime.Now;
            createModel.CreatedBy = _currentUserService.Username;
            _developerPositionRepository.AddDeveloperPosition(createModel);
        }
    }
}
