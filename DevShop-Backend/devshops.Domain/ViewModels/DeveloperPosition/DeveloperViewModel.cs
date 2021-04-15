using devshops.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Domain.ViewModels.DeveloperPositionViewModel
{
    public class DeveloperPositionViewModel
    {
        public int DeveloperId { get; set; }
        public int PositionId { get; set; }
    }

    public class DeveloperPositionCreateModel : AuditableEntity
    {
        public int DeveloperId { get; set; }
        public int PositionId { get; set; }
    }
}
