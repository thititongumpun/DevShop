using devshops.Domain.Common;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Domain.ViewModels.Position
{
    public class PositionViewModel : AuditableEntity
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }

    public class PositionCreateModel : AuditableEntity
    {
        [Required(ErrorMessage = "PositionName Is Required")]
        public string PositionName { get; set; }
    }

    public class PositionGroupModel
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public ICollection<DeveloperModel> Developers { get; set; } = new HashSet<DeveloperModel>();
    }
}
