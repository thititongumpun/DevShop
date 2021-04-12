using devshops.Domain.ViewModels.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Position
{
    public interface IPositionService
    {
        Task<IEnumerable<PositionViewModel>> GetAllPositions();
        void AddPosition(PositionCreateModel position);
        void UpdatePosition(PositionViewModel position);
        void DeletePosition(int id);
    }
}
