using devshops.Core.Repository.Position;
using devshops.Domain.ViewModels.Position;
using devshops.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Position
{
    public class PositionService : IPositionService
    {
        protected readonly IPositionRepository _positionRepository;
        protected readonly IDateTime _dateTime;
        protected readonly ICurrentUserService _currentUserService;
        public PositionService(
            IPositionRepository positionRepository,
            IDateTime dateTime,
            ICurrentUserService currentUserService)
        {
            _positionRepository = positionRepository;
            _dateTime = dateTime;
            _currentUserService = currentUserService;
        }
        public async Task<IEnumerable<PositionGroupModel>> GetAllPositions()
        {
            return await _positionRepository.GetAllPositions();
        }

        public void AddPosition(PositionCreateModel position)
        {
            position.Created = _dateTime.Now;
            position.CreatedBy = _currentUserService.Username;
            _positionRepository.AddPosition(position);
        }

        public void UpdatePosition(PositionViewModel position)
        {
            position.LastModified = _dateTime.Now;
            position.LastModifiedBy = _currentUserService.Username;
            _positionRepository.UpdatePosition(position);
        }

        public void DeletePosition(int id)
        {
            _positionRepository.DeletePosition(id);
        }

        public async Task<PositionGroupModel> GetPositionById(int id)
        {
            return await _positionRepository.GetPositionById(id);
        }
    }
}
