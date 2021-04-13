using devshops.Core.Repository.Position;
using devshops.Domain.ViewModels.Position;
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
        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }
        public async Task<IEnumerable<PositionGroupModel>> GetAllPositions()
        {
            return await _positionRepository.GetAllPositions();
        }

        public void AddPosition(PositionCreateModel position)
        {
            _positionRepository.AddPosition(position);
        }

        public void UpdatePosition(PositionViewModel position)
        {
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
