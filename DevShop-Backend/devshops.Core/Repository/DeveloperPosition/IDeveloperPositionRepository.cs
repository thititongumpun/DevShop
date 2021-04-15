using devshops.Domain.ViewModels.DeveloperPositionViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Repository.DeveloperPosition
{
    public interface IDeveloperPositionRepository
    {
        Task<IEnumerable<DeveloperPositionViewModel>> GetDeveloperPosition();
        void AddDeveloperPosition(DeveloperPositionCreateModel createModel);
    }
}
