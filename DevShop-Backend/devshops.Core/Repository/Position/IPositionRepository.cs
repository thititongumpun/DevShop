using devshops.Domain.ViewModels.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Repository.Position
{
    public interface IPositionRepository
    {
        Task<IEnumerable<PositionGroupModel>> GetAllPositions();
        void AddPosition(PositionCreateModel position);
        void UpdatePosition(PositionViewModel position);
        void DeletePosition(int id);
    }
}
