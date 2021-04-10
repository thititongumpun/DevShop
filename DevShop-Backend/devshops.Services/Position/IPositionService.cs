using devshops.Domain.ViewModels.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Services.Position
{
    public interface IPositionService
    {
        Task<IEnumerable<PositionViewModel>> GetAllPositions();
    }
}
