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
        Task<IEnumerable<PositionViewModel>> GetAllPositions();
        void AddPosition(PositionCreateModel position);
    }
}
