﻿using devshops.Domain.Common;
using devshops.Domain.Developer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Domain.ViewModels.Position
{
    public class PositionViewModel
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }

    public class PositionCreateModel : AuditableEntity
    {
        public string PositionName { get; set; }
    }

    public class PositionGroupModel
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public ICollection<DeveloperViewModel> Developers { get; set; } = new HashSet<DeveloperViewModel>();
    }
}
