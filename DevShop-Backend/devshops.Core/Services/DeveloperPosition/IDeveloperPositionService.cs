using devshops.Domain.ViewModels.DeveloperPositionViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Services.DeveloperPosition
{
    public interface IDeveloperPositionService
    {
        Task<IEnumerable<DeveloperPositionViewModel>> GetDeveloperPosition();
        void AddDeveloperPosition(DeveloperPositionCreateModel createModel);
    }
}
